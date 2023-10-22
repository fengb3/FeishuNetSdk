using Newtonsoft.Json;
namespace FeishuNetSdk.Approval.Spec;
/// <summary>
/// 三方审批实例校验 请求体
/// <para>:::html为了更好地提升接口文档的的易理解性，我们对文档进行了升级，请尽快迁移至[新版本>>](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/approval-v4/external_instance/check)校验三方审批实例数据，用于判断服务端数据是否为最新的。用户提交实例最新更新时间，如果服务端不存在该实例，或者服务端实例更新时间不是最新的，则返回对应实例 id。</para>
/// <para>例如，用户可以每隔5分钟，将最近5分钟产生的实例使用该接口进行对比。</para>
/// <para>接口ID：6907569745298604034</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/historic-version/approval/v2/third-party-approval-integration/external-approval-instance-check</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDNyYjL1QjM24SN0IjN</para>
/// </summary>
public record PostApprovalOpenapiV3ExternalInstanceCheckBodyDto
{
    /// <summary>
    /// <para>实例信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("update_times")]
    public UpdateTimeSuffix[] UpdateTimes { get; set; } = Array.Empty<UpdateTimeSuffix>();

    public record UpdateTimeSuffix
    {
        /// <summary>
        /// <para>审批实例 id</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("instance_id")]
        public string InstanceId { get; set; } = string.Empty;

        /// <summary>
        /// <para>审批实例最近更新时间</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("update_time")]
        public long UpdateTime { get; set; }

        /// <summary>
        /// <para>任务信息</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("tasks")]
        public Task[] Tasks { get; set; } = Array.Empty<Task>();

        public record Task
        {
            /// <summary>
            /// <para>任务 id</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("task_id")]
            public string TaskId { get; set; } = string.Empty;

            /// <summary>
            /// <para>任务最近更新时间</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("update_time")]
            public long UpdateTime { get; set; }
        }
    }
}