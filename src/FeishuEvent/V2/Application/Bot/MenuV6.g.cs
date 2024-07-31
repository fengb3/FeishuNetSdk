// <auto-generated />

using System;
using FeishuNetSdk.FeishuEvent.V2;


namespace  FeishuNetSdk.FeishuEvent.V2.Application.Bot
{
    /// <summary>
    /// 机器人自定义菜单事件<br/>
    /// 当用户点击类型为事件的机器人菜单时触发<br/>
    /// </summary>
    /// <事件类型> application.bot.menu_v6 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/application-v6/bot/events/menu">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// 无
    /// </权限要求>
    /// <字段权限要求>
    /// <ul>
    /// <li> 获取机器人自定义菜单操作人名称 </li>
    /// <li> 获取用户 user ID (仅自建应用) </li>
    /// </ul>
    /// </字段权限要求>
    public class MenuV6 : EventContext<MenuV6.EventData>
    {
        // EventData|operator:operator|operator_name:string||operator_id:user_id|union_id:string||user_id:string||open_id:string||event_key:string||timestamp:int64|
        public class EventData
        {
            	
            /// <summary>
            /// 用户信息
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
            public Operator Operator { get; init; }

            	
            /// <summary>
            /// 菜单事件的唯一标识
            /// 数据校验规则：
            /// 长度范围：1 ～ 30 字符
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("event_key")]
            public string EventKey { get; init; }

            	
            /// <summary>
            /// 用户点击菜单时间
            /// 数据校验规则：
            /// 长度范围：1 ～ 30
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
            public Int64 Timestamp { get; init; }
        }

        // operator|operator_name:string||operator_id:user_id|union_id:string||user_id:string||open_id:string|
        public class Operator
        {
            	
            /// <summary>
            /// 用户名称
            /// 数据校验规则：
            /// 长度范围：1 ～ 100 字符
            /// 字段权限要求：
            /// 获取机器人自定义菜单操作人名称
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("operator_name")]
            public string OperatorName { get; init; }

            	
            /// <summary>
            /// 用户 ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("operator_id")]
            public UserId OperatorId { get; init; }
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