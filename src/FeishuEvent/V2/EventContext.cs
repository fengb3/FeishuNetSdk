using FeishuNetSdk.FeishuEvent;

namespace FeishuNetSdk.FeishuEvent.V2;

/// <summary>
/// v2 事件头
/// </summary>
public class Header
{
	/// <summary>
	/// 字段是事件的唯一标识。
	/// </summary>
	[global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
	public string? EventId { get; set; }

	/// <summary>
	/// 字段即 Verification Token
	/// </summary>
	[global::System.Text.Json.Serialization.JsonPropertyName("token")]
	public string? Token { get; set; }

	/// <summary>
	/// 字段表示事件发送的时间，一般近似于事件发生的时间。
	/// </summary>
	[global::System.Text.Json.Serialization.JsonPropertyName("create_time")]
	public string? CreateTime { get; set; }

	/// <summary>
	/// 字段表示事件类型。
	/// </summary>
	[global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
	public string? EventType { get; set; }

	/// <summary>
	/// 应用 ID
	/// </summary>
	[global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
	public string? TenantKey { get; set; }

	/// <summary>
	/// 租户 Key
	/// </summary>
	[global::System.Text.Json.Serialization.JsonPropertyName("tenant_key")]
	public string? AppId { get; set; }
}

/// <summary>
/// v2 事件包装器
/// </summary>
/// <typeparam name="T"></typeparam>
public class EventContext<T> : IEventContext<T>
{
	/// <summary>
	/// 事件schema = 2.0
	/// </summary>
	[global::System.Text.Json.Serialization.JsonPropertyName("schema")]
	public string Schema { get; init; } = "2.0";

	/// <summary>
	/// 事件头
	/// </summary>
	[global::System.Text.Json.Serialization.JsonPropertyName("header")]
	public Header Header { get; init; } = default!;

	/// <summary>
	/// 事件体
	/// </summary>
	[global::System.Text.Json.Serialization.JsonPropertyName("event")]
	public T Event { get; init; }
}