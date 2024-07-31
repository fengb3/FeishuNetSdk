using FeishuNetSdk.FeishuEvent;

namespace FeishuNetSdk.FeishuEvent.V1;

public interface IV1EventContext
{
	/// <summary>
	/// 字段表示事件发送的时间，一般近似于事件发生的时间。
	/// </summary>
	public string Ts { get; init; }
	
	/// <summary>
	/// 字段是事件的唯一标识。
	/// </summary>
	public string Uuid { get; init; }
	
	/// <summary>
	/// 字段即 Verification Token。
	/// </summary>
	public string Token { get; init; }
	
	/// <summary>
	/// 事件标识，用于区分不同的事件。
	/// </summary>
	public string Type { get; init; }
}

/// <summary>
/// v1 事件包装器
/// </summary>
/// <typeparam name="T"></typeparam>
public record EventContext<T> : IEventContext<T>, IV1EventContext
{
	public string Ts { get; init; }
	
	public string Uuid { get; init; }
	
	public string Token { get; init; }
	
	public string Type { get; init; }
	
	public T Event { get; init; }
}