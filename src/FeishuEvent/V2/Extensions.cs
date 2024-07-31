using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;

namespace FeishuNetSdk.FeishuEvent.V2;

/// <summary>
/// 
/// </summary>
public static class Extensions
{

	/// <summary>
	/// 注入 FeishuEventV2 相关 服务
	/// </summary>
	/// <param name="services"></param>
	/// <returns></returns>
	public static IServiceCollection AddFeishuEventV2(this IServiceCollection services)
	{
		services.AddSingleton<DispatchCenter>();
		return services;
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="json"></param>
	/// <param name="dispatchCenter"></param>
	/// <returns></returns>
	public static object MapFeishuEventV2(JsonElement json, DispatchCenter dispatchCenter)
	{
		json = dispatchCenter.DecryptIfEncrypted(json);
		
		if (json.TryGetProperty("challenge", out var challenge))
			return new { Challenge = challenge.GetString() };
		
		_ = System.Threading.Tasks.Task.Run(() =>dispatchCenter.Dispatch(json));
		
		return new { Message = "OK" };
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="serviceCollection"></param>
	/// <param name="handler"></param>
	/// <exception cref="InvalidOperationException">还没想好怎么做</exception>
	public static void RegisterFeishuEventHandlerV2(this IServiceCollection serviceCollection, Delegate handler)
	{
		throw new NotImplementedException();
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="services"></param>
	/// <param name="handler"></param>
	/// <typeparam name="TEvent"></typeparam>
	public static void RegisterFeishuEventHandlerV2<TEvent>(this IServiceCollection services, Func<TEvent, System.Threading.Tasks.Task> handler)
	{
		DispatchCenter<TEvent>.Register(handler);
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="services"></param>
	/// <param name="handler"></param>
	/// <typeparam name="TEvent"></typeparam>
	/// <typeparam name="T1"></typeparam>
	public static void RegisterFeishuEventHandlerV2<TEvent, T1>(this IServiceCollection services, Func<TEvent, T1, System.Threading.Tasks.Task> handler) 
		where T1 : notnull
	{
		DispatchCenter<TEvent>.Register(handler);
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="services"></param>
	/// <param name="handler"></param>
	/// <typeparam name="TEvent"></typeparam>
	/// <typeparam name="T1"></typeparam>
	/// <typeparam name="T2"></typeparam>
	public static void RegisterFeishuEventHandlerV2<TEvent, T1, T2>(this IServiceCollection services, Func<TEvent, T1, T2, System.Threading.Tasks.Task> handler) 
		where T1 : notnull 
		where T2 : notnull
	{
		DispatchCenter<TEvent>.Register(handler);
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="services"></param>
	/// <param name="handler"></param>
	/// <typeparam name="TEvent"></typeparam>
	/// <typeparam name="T1"></typeparam>
	/// <typeparam name="T2"></typeparam>
	/// <typeparam name="T3"></typeparam>
	public static void RegisterFeishuEventHandlerV2<TEvent, T1, T2, T3>(this IServiceCollection services, Func<TEvent, T1, T2, T3, System.Threading.Tasks.Task> handler) 
		where T1 : notnull 
		where T2 : notnull 
		where T3 : notnull
	{
		DispatchCenter<TEvent>.Register(handler);
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="services"></param>
	/// <param name="handler"></param>
	/// <typeparam name="TEvent"></typeparam>
	/// <typeparam name="T1"></typeparam>
	/// <typeparam name="T2"></typeparam>
	/// <typeparam name="T3"></typeparam>
	/// <typeparam name="T4"></typeparam>
	public static void RegisterFeishuEventHandlerV2<TEvent, T1, T2, T3, T4>(this IServiceCollection services, Func<TEvent, T1, T2, T3, T4, System.Threading.Tasks.Task> handler) 
		where T1 : notnull 
		where T2 : notnull 
		where T3 : notnull 
		where T4 : notnull
	{
		DispatchCenter<TEvent>.Register(handler);
	}
	
	
	// public static void MapFeishuEventV2(this IEndpointRouteBuilder webApp, string pattern)
	// {
	// 	webApp.MapPost(pattern, ([FromBody] JsonElement body, DispatchCenter dispatchCenter, ILogger<DispatchCenter> logger) =>
	// 	{
	// 		var json = dispatchCenter.DecryptIfEncrypted(body);
	// 		
	// 		if (json.TryGetProperty("challenge", out var challenge))
	// 			return Results.Ok(new
	// 			{
	// 				Challenge = challenge.GetString()
	// 			});
	// 		
	// 		_ = System.Threading.Tasks.Task.Run(() =>dispatchCenter.Dispatch(json));
	// 		
	// 		return Results.Ok(new
	// 		{
	// 			Message = "OK"
	// 		});
	// 	});
	// }
}