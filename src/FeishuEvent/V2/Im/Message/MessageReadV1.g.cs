// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Im.Message
{
    /// <summary>
    /// 消息已读<br/>
    /// 用户阅读机器人发送的单聊消息后触发此事件。<br/>
    /// </summary>
    /// <事件类型> im.message.message_read_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/message/events/message_read">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取与发送单聊、群组消息 </li>
    /// <li> 获取单聊、群组消息 </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// <ul>
    /// <li> 获取用户 user ID (仅自建应用) </li>
    /// </ul>
    /// </字段权限要求>
    public class MessageReadV1 : EventContext<MessageReadV1.EventData>
    {
        // EventData|reader:event_message_reader|reader_id:user_id|union_id:string||user_id:string||open_id:string||read_time:string||tenant_key:string||message_id_list:string|
        public class EventData
        {
            	
            /// <summary>
            /// 
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("reader")]
            public EventMessageReader Reader { get; init; }

            	
            /// <summary>
            /// 消息列表
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("message_id_list")]
            public string[] MessageIdList { get; init; }
        }

        // event_message_reader|reader_id:user_id|union_id:string||user_id:string||open_id:string||read_time:string||tenant_key:string|
        public class EventMessageReader
        {
            	
            /// <summary>
            /// 用户 ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("reader_id")]
            public UserId ReaderId { get; init; }

            	
            /// <summary>
            /// 阅读时间
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("read_time")]
            public string ReadTime { get; init; }

            	
            /// <summary>
            /// 租户key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用里面的唯一标识
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("tenant_key")]
            public string TenantKey { get; init; }
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