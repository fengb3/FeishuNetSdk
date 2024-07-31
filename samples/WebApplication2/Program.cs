using FeishuNetSdk;
using FeishuNetSdk.FeishuEvent.V2;
using FeishuNetSdk.FeishuEvent.V2.Im.Message;
using FeishuNetSdk.Im;
using static System.Guid;

namespace WebApplication2;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddFeishuEventV2();
        builder.Services.AddFeishuNetSdk(options =>
        {
            options.AppId     = "cli_a609xxxxxxxxxxx900e";
            options.AppSecret = "zCAO4xxxxxxxxxxxxxvbHNQVpZoK73";
        });

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        
        app.MapFeishuEventV2("/feishu/event/v2")
           .WithHandler(async (ReceiveV1 @event, ILogger<Program> logger, IFeishuTenantApi tenantApi) =>
            {
                logger.LogInformation("收到飞书事件: {event}", @event.Header.EventType);

                await tenantApi.PostImV1MessagesAsync("chat_id", new PostImV1MessagesBodyDto()
                {
                    MsgType = "text",
                    Content = "{\"text\":\"Hello, World!\"}",
                    ReceiveId = @event.Event.Message.ChatId,
                    Uuid = "2421B4BD-EC4C-4A08-A53F-9C0CD49A8EC8"
                });
            })
           .WithName("FeishuEventV2")
           .WithTags("飞书事件回调 V2")
           .WithOpenApi()
            ;

        app.Run();
    }
}

public static class Extensions
{
    public static RouteHandlerBuilder MapFeishuEventV2(this IEndpointRouteBuilder endpoints, string pattern)
    {
        return endpoints.MapPost(pattern, FeishuNetSdk.FeishuEvent.V2.Extensions.MapFeishuEventV2);
    }
    
    public static RouteHandlerBuilder WithHandler<TEvent>(this RouteHandlerBuilder builder, Func<TEvent, Task> func)
    {
        DispatchCenter<TEvent>.Register(func);
        return builder;
    }
    
    public static RouteHandlerBuilder WithHandler<TEvent, T1>(this RouteHandlerBuilder builder, Func<TEvent, T1, Task> func) 
        where T1 : class
    {
        DispatchCenter<TEvent>.Register(func);
        return builder;
    }
    
    public static RouteHandlerBuilder WithHandler<TEvent, T1, T2>(this RouteHandlerBuilder builder, Func<TEvent, T1, T2, Task> func) 
        where T1 : class
        where T2 : class
    {
        DispatchCenter<TEvent>.Register(func);
        return builder;
    }
    
    public static RouteHandlerBuilder WithHandler<TEvent, T1, T2, T3>(this RouteHandlerBuilder builder, Func<TEvent, T1, T2, T3, Task> func) 
        where T1 : class
        where T2 : class
        where T3 : class
    {
        DispatchCenter<TEvent>.Register(func);
        return builder;
    }
    
    public static RouteHandlerBuilder WithHandler<TEvent, T1, T2, T3, T4>(this RouteHandlerBuilder builder, Func<TEvent, T1, T2, T3, T4, Task> func) 
        where T1 : class
        where T2 : class
        where T3 : class
        where T4 : class
    {
        DispatchCenter<TEvent>.Register(func);
        return builder;
    }
}