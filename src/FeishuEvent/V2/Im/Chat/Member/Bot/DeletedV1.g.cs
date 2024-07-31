// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace  FeishuNetSdk.FeishuEvent.V2.Im.Chat.Member.Bot
{
    /// <summary>
    /// 机器人被移出群<br/>
    /// 机器人被移出群聊后触发此事件。<br/>
    /// </summary>
    /// <事件类型> im.chat.member.bot.deleted_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/im-v1/chat-member-bot/events/deleted">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取与更新群组信息 </li>
    /// <li> 获取群组信息 </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// <ul>
    /// <li> 获取用户 user ID (仅自建应用) </li>
    /// </ul>
    /// </字段权限要求>
    public class DeletedV1 : EventContext<DeletedV1.EventData>
    {
        // EventData|chat_id:string||operator_id:user_id|union_id:string||user_id:string||open_id:string||external:boolean||operator_tenant_key:string||name:string||i18n_names:i18n_names|zh_cn:string||en_us:string||ja_jp:string|
        public class EventData
        {
            	
            /// <summary>
            /// 群组 ID，详情参见群ID 说明
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
            public string ChatId { get; init; }

            	
            /// <summary>
            /// 用户 ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("operator_id")]
            public UserId OperatorId { get; init; }

            	
            /// <summary>
            /// 是否是外部群
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("external")]
            public bool External { get; init; }

            	
            /// <summary>
            /// 操作者租户 Key
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("operator_tenant_key")]
            public string OperatorTenantKey { get; init; }

            	
            /// <summary>
            /// 群名称
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("name")]
            public string Name { get; init; }

            	
            /// <summary>
            /// 群国际化名称
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("i18n_names")]
            public I18nNames I18nNames { get; init; }
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

        // i18n_names|zh_cn:string||en_us:string||ja_jp:string|
        public class I18nNames
        {
            	
            /// <summary>
            /// 中文名
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("zh_cn")]
            public string ZhCn { get; init; }

            	
            /// <summary>
            /// 英文名
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("en_us")]
            public string EnUs { get; init; }

            	
            /// <summary>
            /// 日文名
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("ja_jp")]
            public string JaJp { get; init; }
        }
    }
}