// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-10-12
//
// Last Modified By : yxr
// Last Modified On : 2024-10-12
// ************************************************************************
// <copyright file="CorehrCostCenterDeletedV2EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>删除成本中心 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Corehr.Events;
/// <summary>
/// 删除成本中心 事件体
/// <para>飞书人事中「成本中心被删除」时将触发此事件。</para>
/// <para>{使用示例}(url=/api/tools/api_explore/api_explore_config?project=corehr&amp;version=v2&amp;resource=cost_center&amp;event=deleted)</para>
/// <para>接口ID：7423693709786103811</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/cost_center/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcost_center%2fevents%2fdeleted</para>
/// </summary>
public record CorehrCostCenterDeletedV2EventBodyDto() : EventBodyDto("corehr.cost_center.deleted_v2")
{
    /// <summary>
    /// <para>被删除成本中心的 ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cost_center_id")]
    public string? CostCenterId { get; set; }
}
