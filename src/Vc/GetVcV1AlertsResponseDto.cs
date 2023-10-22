using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 获取告警记录 响应体
/// <para>获取特定条件下租户的设备告警记录。</para>
/// <para>接口ID：7146108826851770396</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/alert/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2falert%2flist</para>
/// </summary>
public record GetVcV1AlertsResponseDto
{
    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：50</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>告警记录</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public Alert[]? Items { get; set; }

    /// <summary>
    /// <para>告警记录</para>
    /// </summary>
    public record Alert
    {
        /// <summary>
        /// <para>告警ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：7115030004018184212</para>
        /// </summary>
        [JsonProperty("alert_id")]
        public string? AlertId { get; set; }

        /// <summary>
        /// <para>触发告警规则的会议室/服务器具体的名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：XX层级</para>
        /// </summary>
        [JsonProperty("resource_scope")]
        public string? ResourceScope { get; set; }

        /// <summary>
        /// <para>触发告警规则的监控对象</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：飞书会议室</item>
        /// <item>2：飞书会议室签到板</item>
        /// <item>3：飞书投屏盒子</item>
        /// <item>4：飞书投屏</item>
        /// <item>5：sip会议室系统</item>
        /// <item>6：erc节点</item>
        /// <item>7：飞书传感器</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("monitor_target")]
        public int? MonitorTarget { get; set; }

        /// <summary>
        /// <para>告警规则的规则描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：连续1个周期（共1分钟），控制器电量<50%，则告警</para>
        /// </summary>
        [JsonProperty("alert_strategy")]
        public string? AlertStrategy { get; set; }

        /// <summary>
        /// <para>告警通知发生时间（unix时间，单位秒）</para>
        /// <para>必填：否</para>
        /// <para>示例值：1656914944</para>
        /// </summary>
        [JsonProperty("alert_time")]
        public string? AlertTime { get; set; }

        /// <summary>
        /// <para>告警等级：严重/警告/提醒</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：提醒</item>
        /// <item>1：警告</item>
        /// <item>2：严重</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("alert_level")]
        public int? AlertLevel { get; set; }

        /// <summary>
        /// <para>告警联系人</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("contacts")]
        public Contact[]? Contacts { get; set; }

        /// <summary>
        /// <para>告警联系人</para>
        /// </summary>
        public record Contact
        {
            /// <summary>
            /// <para>联系人类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：用户</item>
            /// <item>2：用户组</item>
            /// <item>3：部门</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("contact_type")]
            public int? ContactType { get; set; }

            /// <summary>
            /// <para>联系人名</para>
            /// <para>必填：否</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonProperty("contact_name")]
            public string? ContactName { get; set; }
        }

        /// <summary>
        /// <para>通知方式</para>
        /// <para>必填：否</para>
        /// <para>示例值：[0,1]</para>
        /// </summary>
        [JsonProperty("notifyMethods")]
        public int[]? NotifyMethods { get; set; }

        /// <summary>
        /// <para>规则名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：签到板断开连接</para>
        /// </summary>
        [JsonProperty("alertRule")]
        public string? AlertRule { get; set; }

        /// <summary>
        /// <para>处理时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1656914944</para>
        /// </summary>
        [JsonProperty("process_time")]
        public string? ProcessTime { get; set; }

        /// <summary>
        /// <para>恢复时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：1656914944</para>
        /// </summary>
        [JsonProperty("recover_time")]
        public string? RecoverTime { get; set; }

        /// <summary>
        /// <para>处理状态：待处理/处理中/已恢复</para>
        /// <para>必填：否</para>
        /// <para>示例值：2</para>
        /// <para>可选值：<list type="bullet">
        /// <item>0：待处理（deprecated）</item>
        /// <item>1：待处理</item>
        /// <item>2：处理中</item>
        /// <item>3：已恢复（deprecated）</item>
        /// <item>4：已恢复</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("process_status")]
        public int? ProcessStatus { get; set; }
    }
}