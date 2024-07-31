// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Corehr.Employment
{
    /// <summary>
    /// 【事件】创建雇佣信息<br/>
    /// 员工在飞书人事的「雇佣信息被创建」时将触发此事件。<br/>
    /// </summary>
    /// <事件类型> corehr.employment.created_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employment/events/created">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取核心人事信息 </li>
    /// <li> 获取雇佣信息 </li>
    /// <li> 读写雇佣信息 (仅自建应用) </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// <ul>
    /// <li> 获取用户 user ID (仅自建应用) </li>
    /// </ul>
    /// </字段权限要求>
    public class CreatedV1 : EventContext<CreatedV1.EventData>
    {
        // EventData|employment_id:string||target_user_id:user_id|union_id:string||user_id:string||open_id:string|
        public class EventData
        {
            	
            /// <summary>
            /// 被创建的雇佣信息的 ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("employment_id")]
            public string EmploymentId { get; init; }

            	
            /// <summary>
            /// 用户 ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("target_user_id")]
            public UserId TargetUserId { get; init; }
        }

        // user_id|union_id:string||user_id:string||open_id:string|
        public class UserId
        {
            	
            /// <summary>
            /// 用户的 union id
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("union_id")]
            public string UnionId { get; init; }

            	
            /// <summary>
            /// 用户的 user id
            /// 字段权限要求：
            /// 获取用户 user ID仅自建应用
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
            public string UserIdValue { get; init; }

            	
            /// <summary>
            /// 用户的 open id
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("open_id")]
            public string OpenId { get; init; }
        }
    }
}