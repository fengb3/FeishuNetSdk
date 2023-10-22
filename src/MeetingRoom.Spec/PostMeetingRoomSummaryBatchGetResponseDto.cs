using Newtonsoft.Json;
namespace FeishuNetSdk.MeetingRoom.Spec;
/// <summary>
/// 查询会议室日程主题和会议详情 响应体
/// <para>通过日程的Uid和Original time，查询会议室日程主题。 </para>
/// <para>接口ID：6922096654371831836</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/calendar-v4/meeting-room-event/</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuIjM5UjLyITO14iMykTN%2f</para>
/// </summary>
public record PostMeetingRoomSummaryBatchGetResponseDto
{
    /// <summary>
    /// <para>成功查询到的日程信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("eventInfos")]
    public EventInfo[]? EventInfos { get; set; }

    public record EventInfo
    {
        /// <summary>
        /// <para>日程的唯一id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// <para>日程实例原始时间。非重复性日程和重复性日程，此处为0；重复性日程的例外，为对应的original_time</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("original_time")]
        public int? OriginalTime { get; set; }

        /// <summary>
        /// <para>日程主题</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// <para>视频会议信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("vchat")]
        public VchatSuffix? Vchat { get; set; }

        public record VchatSuffix
        {
            /// <summary>
            /// <para>视屏会议类型 <br> **可选值有：**<br> - `vc`：飞书视频会议，取该类型时，其他字段无效。<br> - `third_party`：第三方链接视频会议，取该类型时，icon_type、description、meeting_url字段生效。<br> - `no_meeting`：无视频会议，取该类型时，其他字段无效。<br>- `lark_live`：飞书直播，内部类型，飞书客户端使用，API不支持创建，只读。<br>- `unknown`：未知类型，做兼容使用，飞书客户端使用，API不支持创建，只读。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("vc_type")]
            public string? VcType { get; set; }

            /// <summary>
            /// <para>第三方视频会议icon类型；可以为空，为空展示默认icon。<br> **可选值有：** <br>- `vc`：飞书视频会议icon<br>- `live`：直播视频会议icon <br>-  `default`：默认icon</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("icon_type")]
            public string? IconType { get; set; }

            /// <summary>
            /// <para>第三方视频会议文案，可以为空，为空展示默认文案</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("description")]
            public string? Description { get; set; }

            /// <summary>
            /// <para>视频会议URL</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("meeting_url")]
            public string? MeetingUrl { get; set; }
        }
    }

    /// <summary>
    /// <para>没有查询到的日程</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("errorEventUids")]
    public ErrorEventUid[]? ErrorEventUids { get; set; }

    public record ErrorEventUid
    {
        /// <summary>
        /// <para>日程的唯一id</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// <para>日程实例原始时间。非重复性日程和重复性日程，此处为0；重复性日程的例外，为对应的original_time</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("original_time")]
        public int? OriginalTime { get; set; }

        /// <summary>
        /// <para>错误信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("error_msg")]
        public string? ErrorMsg { get; set; }
    }
}