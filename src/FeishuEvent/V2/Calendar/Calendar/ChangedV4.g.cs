// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace  FeishuNetSdk.FeishuEvent.V2.Calendar.Calendar
{
    /// <summary>
    /// 日历变更<br/>
    /// 当用户订阅日历变更事件后，如果用户日历列表内发生了日历变动，则会触发该事件。<br/>
    /// </summary>
    /// <事件类型> calendar.calendar.changed_v4 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/calendar-v4/calendar/events/changed">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 更新日历及日程信息 </li>
    /// <li> 获取日历、日程及忙闲信息 </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// 无
    /// </字段权限要求>
    public class ChangedV4 : EventContext<ChangedV4.EventData>
    {
        // EventData|user_id_list:user_id|union_id:string||user_id:string||open_id:string|
        public class EventData
        {
            	
            /// <summary>
            /// 需要推送事件的用户列表。关于用户不同 ID 的介绍，参见用户身份概述
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("user_id_list")]
            public UserId[] UserIdList { get; init; }
        }

        // user_id|union_id:string||user_id:string||open_id:string|
        public class UserId
        {
            	
            /// <summary>
            /// 用户的 union_id。
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("union_id")]
            public string UnionId { get; init; }

            	
            /// <summary>
            /// 用户的 user_id。
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
            public string UserIdValue { get; init; }

            	
            /// <summary>
            /// 用户的 open_id。
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("open_id")]
            public string OpenId { get; init; }
        }
    }
}