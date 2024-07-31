// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Hire.Application
{
    /// <summary>
    /// 删除投递<br/>
    /// 投递被删除后会推送该事件<br/>
    /// </summary>
    /// <事件类型> hire.application.deleted_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/application/events/deleted">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取投递信息 </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// 无
    /// </字段权限要求>
    public class DeletedV1 : EventContext<DeletedV1.EventData>
    {
        // EventData|application_ids:string|
        public class EventData
        {
            	
            /// <summary>
            /// 投递 ID 列表
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("application_ids")]
            public string[] ApplicationIds { get; init; }
        }
    }
}