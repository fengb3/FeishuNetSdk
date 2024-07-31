// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Corehr.Person
{
    /// <summary>
    /// 【事件】更新个人信息<br/>
    /// 员工在飞书人事的「个人信息被更新」时将触发此事件，个人信息的创建和删除不会触发该事件。注：籍贯、政治面貌、户口类型、户口所在地变化不会触发该事件<br/>
    /// </summary>
    /// <事件类型> corehr.person.updated_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/person/events/updated">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取核心人事信息 </li>
    /// <li> 获取员工信息 </li>
    /// <li> 查看员工个人信息 </li>
    /// <li> 读写员工信息 (仅自建应用) </li>
    /// <li> 读写员工的个人信息 (仅自建应用) </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// 无
    /// </字段权限要求>
    public class UpdatedV1 : EventContext<UpdatedV1.EventData>
    {
        // EventData|person_id:string||field_changes:string|
        public class EventData
        {
            	
            /// <summary>
            /// 被更新个人信息的 ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("person_id")]
            public string PersonId { get; init; }

            	
            /// <summary>
            /// 发生变更的字段，若部分字段变更无需接受事件消息，可根据该字段进行事件消息过滤
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("field_changes")]
            public string[] FieldChanges { get; init; }
        }
    }
}