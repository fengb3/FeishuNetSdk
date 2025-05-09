// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="CorehrJobChangeStatusUpdatedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>异动状态变更 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 异动状态变更 事件体
/// <para>在异动审批状态变更、异动生效时都会触发该事件，审批结果产生的场景包括撤销、审批通过、审批拒绝</para>
/// <para>{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=job_change&amp;event=status_updated)</para>
/// <para>接口ID：7407271999612436508</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job_change/job-change-events/status_updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fjob_change%2fevents%2fstatus_updated</para>
/// </summary>
public record CorehrJobChangeStatusUpdatedV2EventBodyDto() : EventBodyDto("corehr.job_change.status_updated_v2")
{
    /// <summary>
    /// <para>雇员ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string? EmploymentId { get; set; }

    /// <summary>
    /// <para>用户 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("target_user_id")]
    public UserIdSuffix? TargetUserId { get; set; }

    /// <summary>
    /// <para>异动记录 id</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("job_change_id")]
    public string? JobChangeId { get; set; }

    /// <summary>
    /// <para>异动属性/方式</para>
    /// <para>**可选值有**：</para>
    /// <para>1:直接异动：无需审批，异动状态直接为审批通过,2:发起异动：需要走异动流程</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：直接异动</item>
    /// <item>2：发起异动</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("transfer_mode")]
    public int? TransferMode { get; set; }

    /// <summary>
    /// <para>异动类型唯一标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("transfer_type_unique_identifier")]
    public string? TransferTypeUniqueIdentifier { get; set; }

    /// <summary>
    /// <para>异动原因唯一标识</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("transfer_reason_unique_identifier")]
    public string? TransferReasonUniqueIdentifier { get; set; }

    /// <summary>
    /// <para>异动关联流程 id，如果是直接异动，则不需要关联流程</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("process_id")]
    public string? ProcessId { get; set; }

    /// <summary>
    /// <para>异动生效日期</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("effective_date")]
    public string? EffectiveDate { get; set; }

    /// <summary>
    /// <para>异动状态</para>
    /// <para>**可选值有**：</para>
    /// <para>1:异动发起 = 审批中状态,2:已撤销,3:已拒绝,4:审批通过,5:已生效（到了生效日期后就生效）,6:无需审批</para>
    /// <para>必填：否</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：异动发起 = 审批中状态</item>
    /// <item>2：已撤销</item>
    /// <item>3：已拒绝</item>
    /// <item>4：审批通过</item>
    /// <item>5：已生效（到了生效日期后就生效）</item>
    /// <item>6：无需审批</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("status")]
    public int? Status { get; set; }

    /// <summary>
    /// <para>异动记录标识符</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("transfer_key")]
    public string? TransferKey { get; set; }
}
