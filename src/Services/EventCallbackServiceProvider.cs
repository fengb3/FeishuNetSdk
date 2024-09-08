// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-08-31
//
// Last Modified By : yxr
// Last Modified On : 2024-09-07
// ************************************************************************
// <copyright file="EventCallbackServiceProvider.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace FeishuNetSdk.Services
{
    /// <summary>
    /// �¼��ص�����
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="options"></param>
    /// <param name="scopeFactory"></param>
    public class EventCallbackServiceProvider(ILogger<EventCallbackServiceProvider> logger, IOptionsMonitor<FeishuNetSdkOptions> options, IServiceScopeFactory scopeFactory) : IEventCallbackServiceProvider
    {
        private static EventHandlerDescriptor[]? _cache;

        /// <summary>
        /// �����¼�ִ�з���
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EventHandlerDescriptor> FindAllHandlers()
        {
            if (_cache is not null) return _cache;
            lock (this)
            {
                if (_cache is not null) return _cache;

                var baseType = typeof(IEventCallbackHandler<,>);
                var types = ReflectionHelper.GetFinalSubTypes(baseType);

                _cache = types
                    .Select(typeInfo =>
                    {
                        var firstArgumentType = GetArgumentTypes(typeInfo, baseType);
                        return new EventHandlerDescriptor
                        {
                            EventHandlerName = typeInfo.Name,
                            EventHandlerType = typeInfo,
                            EventName = firstArgumentType.Name,
                            EventType = firstArgumentType,
                            NotAllowRepeat = firstArgumentType.IsAssignableTo(typeof(IAmCallbackDto))
                        };
                    })
                    .ToArray();

                var check_repeated = _cache.Where(p => p.NotAllowRepeat)
                    .GroupBy(p => p.EventType)
                    .Where(p => p.Count() > 1)
                    .Select(p => p.Key.FullName);
                if (check_repeated.Any())
                    throw new Exception($"�ظ�����Ļص���������{string.Join("��", check_repeated)}");
            }

            return _cache;
        }
        private static Type GetArgumentTypes(Type type, Type baseType)
        {
            return type.GetTypeInfo()
                .ImplementedInterfaces
                .Single(r => r.IsGenericType && r.GetGenericTypeDefinition() == baseType)
                .GetGenericArguments()
                .First();
        }
        private IEnumerable<EventHandlerDescriptor>? GetHandlerDescriptorByEvent(Type eventType)
        {
            if (_cache is null)
                FindAllHandlers();

            return _cache?.Where(p => p.EventType == eventType);
        }

        /// <summary>
        /// ִ���¼�����
        /// </summary>
        public async Task<HandleResult> HandleAsync(object input)
        {
            var serializeString = JsonSerializer.Serialize(input);
            if (serializeString.IsEncryptedObject(out var encryptedString) && encryptedString != null)
            {
                if (options.CurrentValue.EncryptKey == null) return new HandleResult(Error: "δ���ý�����Կ");
                try
                {
                    serializeString = AesCipher.DecryptString(encryptedString, options.CurrentValue.EncryptKey);
                }
                catch (Exception ex)
                {
                    return new HandleResult(Error: $"����ʧ�ܣ�{(ex.InnerException ?? ex).Message}");
                }
            }
            try
            {
                return await HandleAsync(serializeString);
            }
            catch (Exception ex)
            {
                return new HandleResult(Error: $"�¼�ִ�г����쳣��{(ex.InnerException ?? ex).Message}");
            }
        }

        /// <summary>
        /// ִ���¼�����
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public async Task<HandleResult> HandleAsync(string json)
        {
            logger.LogInformation("�¼���Ϣ��{json}", json);

            json = json.FixDiscriminator();
            var dto = JsonSerializer.Deserialize<EventDto>(json);

            if (dto is null) return new HandleResult(Error: $"�����л��¼���ʧ�ܣ�{json}");
            logger.LogInformation("�����л��ɹ���{event_type}", dto.Discriminator);

            if (!string.IsNullOrWhiteSpace(dto.Token) && dto.Token != options.CurrentValue.VerificationToken)
                return new HandleResult(Error: $"Ӧ�ñ�ʶ��һ�£�VerificationToken: {options.CurrentValue.VerificationToken}");

            if (dto is UrlVerificationDto urlVerification)
                return new HandleResult(true, Dto: urlVerification);

            return await HandleAsync(dto);
        }

        /// <summary>
        /// ִ���¼�����
        /// </summary>
        /// <param name="eventDto"></param>
        /// <returns></returns>
        private async Task<HandleResult> HandleAsync(EventDto eventDto)
        {
            var handlers = GetHandlerDescriptorByEvent(eventDto.GetType())?.ToArray();
            if (handlers is null || handlers.Length == 0)
                return new HandleResult(Error: $"δ�����¼���������{eventDto.Discriminator}");

            logger.LogInformation("�¼����������� ��{count}", handlers.Length);

            (int millisecond, string message) = (2700, "ִ�г�ʱ��δ����3���������Ӧ");

            using var scope = scopeFactory.CreateScope();
            if (eventDto.GetType().GetGenericTypeDefinition() == typeof(CallbackV2Dto<>))
            {
                if (handlers.Length > 1)
                    return new HandleResult(Error: $"�ص������������ظ����壺{(string.Join("��", handlers.Select(k => k.EventHandlerName)))}");

                //�ص�����ͬһ���ص�ֻ����һ��������
                var eventHandlerType = handlers[0].EventHandlerType;
                var handlerInstance = scope.ServiceProvider.GetRequiredService(eventHandlerType);
                dynamic? task = eventHandlerType.GetMethod("ExecuteAsync")?.Invoke(handlerInstance, [eventDto]);
                await task?.WaitAsync(TimeSpan.FromMilliseconds(millisecond));
                return new HandleResult(true, Dto: task?.Result);
            }
            else
            {
                var tasks = handlers
                    .Select(p => new
                    {
                        p.EventHandlerType,
                        EventMethod = p.EventHandlerType.GetMethod("ExecuteAsync", [p.EventType])
                    })
                    .Where(p => p.EventMethod is not null)
                    .Select(p =>
                    {
                        var handlerInstance = scope.ServiceProvider.GetRequiredService(p.EventHandlerType);
                        return (System.Threading.Tasks.Task?)p.EventMethod!.Invoke(handlerInstance, [eventDto]);
                    })
                    .Where(p => p is not null)
                    .Select(p => p!)
                    .ToArray();

                //�¼�������������ִ����ɲ�����
                var is_all_success = System.Threading.Tasks.Task.WaitAll(tasks, millisecond);
                if (!is_all_success) return new HandleResult(Error: message);

                return new HandleResult(true);
            }
        }

        /// <summary>
        /// �¼�����ִ�н��
        /// </summary>
        /// <param name="Success"></param>
        /// <param name="Error"></param>
        /// <param name="Dto"></param>
        public record HandleResult(
            [property: JsonPropertyName("success")] bool Success = false,
            [property: JsonPropertyName("error")] string? Error = null,
            [property: JsonPropertyName("dto")] object? Dto = null);
    }
}
