// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Corehr.Person
{
    /// <summary>
    /// 【事件】个人信息删除<br/>
    /// 个人信息删除<br/>
    /// </summary>
    /// <事件类型> corehr.person.deleted_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/person/events/deleted">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取核心人事信息 </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// 无
    /// </字段权限要求>
    public class DeletedV1 : EventContext<DeletedV1.EventData>
    {
        // EventData|person_id:string|
        public class EventData
        {
            	
            /// <summary>
            /// 人员ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("person_id")]
            public string PersonId { get; init; }
        }
    }
}