using Newtonsoft.Json;
namespace FeishuNetSdk.Attendance;
/// <summary>
/// 批量查询打卡流水 响应体
/// <para>批量查询授权内员工的实际打卡流水记录。例如，企业给一个员工设定的班次是上午 9 点和下午 6 点各打一次上下班卡，但是该员工在这期间打了多次卡，该接口会把所有的打卡记录都返回。</para>
/// <para>接口ID：7044467124773617665</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/attendance-v1/user_task/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fattendance-v1%2fuser_flow%2fquery</para>
/// </summary>
public record PostAttendanceV1UserFlowsQueryResponseDto
{
    /// <summary>
    /// <para>打卡记录列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("user_flow_results")]
    public UserFlow[]? UserFlowResults { get; set; }

    /// <summary>
    /// <para>打卡记录列表</para>
    /// </summary>
    public record UserFlow
    {
        /// <summary>
        /// <para>用户 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>记录创建者 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：abd754f7</para>
        /// </summary>
        [JsonProperty("creator_id")]
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// <para>打卡位置名称信息</para>
        /// <para>必填：是</para>
        /// <para>示例值：西溪八方城</para>
        /// </summary>
        [JsonProperty("location_name")]
        public string LocationName { get; set; } = string.Empty;

        /// <summary>
        /// <para>打卡时间，精确到秒的时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1611476284</para>
        /// </summary>
        [JsonProperty("check_time")]
        public string CheckTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>打卡备注</para>
        /// <para>必填：是</para>
        /// <para>示例值：上班打卡</para>
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; } = string.Empty;

        /// <summary>
        /// <para>打卡记录 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6709359313699356941</para>
        /// </summary>
        [JsonProperty("record_id")]
        public string? RecordId { get; set; }

        /// <summary>
        /// <para>打卡 Wi-Fi 的 SSID</para>
        /// <para>必填：否</para>
        /// <para>示例值：b0:b8:67:5c:1d:72</para>
        /// </summary>
        [JsonProperty("ssid")]
        public string? Ssid { get; set; }

        /// <summary>
        /// <para>打卡 Wi-Fi 的 MAC 地址</para>
        /// <para>必填：否</para>
        /// <para>示例值：b0:b8:67:5c:1d:72</para>
        /// </summary>
        [JsonProperty("bssid")]
        public string? Bssid { get; set; }

        /// <summary>
        /// <para>是否为外勤打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("is_field")]
        public bool? IsField { get; set; }

        /// <summary>
        /// <para>是否为 Wi-Fi 打卡</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("is_wifi")]
        public bool? IsWifi { get; set; }

        /// <summary>
        /// <para>记录生成方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：7</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：用户打卡</item>
        /// <item>1：管理员修改</item>
        /// <item>2：用户补卡</item>
        /// <item>3：系统自动生成</item>
        /// <item>4：下班免打卡</item>
        /// <item>5：考勤机</item>
        /// <item>6：极速打卡</item>
        /// <item>7：考勤开放平台导入</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("type")]
        public int? Type { get; set; }

        /// <summary>
        /// <para>打卡照片列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("photo_urls")]
        public string[]? PhotoUrls { get; set; }

        /// <summary>
        /// <para>打卡结果</para>
        /// <para>必填：否</para>
        /// <para>示例值：Invalid</para>
        /// <para>可选值：<list type="bullet">
        /// <item>NoNeedCheck：无需打卡</item>
        /// <item>SystemCheck：系统打卡</item>
        /// <item>Normal：正常</item>
        /// <item>Early：早退</item>
        /// <item>Late：迟到</item>
        /// <item>SeriousLate：严重迟到</item>
        /// <item>Lack：缺卡</item>
        /// <item>Invalid：无效</item>
        /// <item>None：无状态</item>
        /// <item>Todo：尚未打卡</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("check_result")]
        public string? CheckResult { get; set; }
    }
}