// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Vc.Meeting
{
    /// <summary>
    /// 停止录制<br/>
    /// 发生在录制结束时【仅通过Open API预约的会议会产生此类事件】<br/>
    /// </summary>
    /// <事件类型> vc.meeting.recording_ended_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/meeting/events/recording_ended">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取会议信息 </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// <ul>
    /// <li> 获取用户 user ID (仅自建应用) </li>
    /// </ul>
    /// </字段权限要求>
    public class RecordingEndedV1 : EventContext<RecordingEndedV1.EventData>
    {
        // EventData|meeting:meeting_event_meeting|id:string||topic:string||meeting_no:string||start_time:string||end_time:string||host_user:meeting_event_user|id:user_id|union_id:string||user_id:string||open_id:string||user_role:int||user_type:int||owner:meeting_event_user|id:user_id|union_id:string||user_id:string||open_id:string||user_role:int||user_type:int||operator:meeting_event_user|id:user_id|union_id:string||user_id:string||open_id:string||user_role:int||user_type:int|
        public class EventData
        {
            	
            /// <summary>
            /// 会议数据
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("meeting")]
            public MeetingEventMeeting Meeting { get; init; }

            	
            /// <summary>
            /// 事件操作人
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
            public MeetingEventUser Operator { get; init; }
        }

        // meeting_event_meeting|id:string||topic:string||meeting_no:string||start_time:string||end_time:string||host_user:meeting_event_user|id:user_id|union_id:string||user_id:string||open_id:string||user_role:int||user_type:int||owner:meeting_event_user|id:user_id|union_id:string||user_id:string||open_id:string||user_role:int||user_type:int|
        public class MeetingEventMeeting
        {
            	
            /// <summary>
            /// 会议ID（视频会议的唯一标识，视频会议开始后才会产生）
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("id")]
            public string Id { get; init; }

            	
            /// <summary>
            /// 会议主题
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
            public string Topic { get; init; }

            	
            /// <summary>
            /// 9位会议号（飞书用户可通过输入9位会议号快捷入会）
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("meeting_no")]
            public string MeetingNo { get; init; }

            	
            /// <summary>
            /// 会议结束时间（unix时间，单位：秒）
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
            public string StartTime { get; init; }

            	
            /// <summary>
            /// 会议结束时间（unix时间，单位：秒）
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
            public string EndTime { get; init; }

            	
            /// <summary>
            /// 会议主持人
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("host_user")]
            public MeetingEventUser HostUser { get; init; }

            	
            /// <summary>
            /// 会议拥有者
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
            public MeetingEventUser Owner { get; init; }
        }

        // meeting_event_user|id:user_id|union_id:string||user_id:string||open_id:string||user_role:int||user_type:int|
        public class MeetingEventUser
        {
            	
            /// <summary>
            /// 用户 ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("id")]
            public UserId Id { get; init; }

            	
            /// <summary>
            /// 用户会中角色
            /// 可选值有：
            /// 1：普通参会人2：主持人3：联席主持人
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("user_role")]
            public int UserRole { get; init; }

            	
            /// <summary>
            /// 用户类型
            /// 可选值有：
            /// 1：飞书用户2：rooms用户3：文档用户4：neo单品用户5：neo单品游客用户
            /// 展开
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("user_type")]
            public int UserType { get; init; }
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