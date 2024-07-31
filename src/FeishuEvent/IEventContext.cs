namespace FeishuNetSdk.FeishuEvent;



/// <summary>
/// 事件包装器 接口
/// </summary>
/// <typeparam name="T">事件体类型</typeparam>
public interface IEventContext<T>
{
	/// <summary>
	/// 事件体数据, 根据不同的事件类型，数据结构不同
	/// </summary>
	public T Event { get; init; }
	
}