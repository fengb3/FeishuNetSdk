// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2MetricFieldsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取指标字段信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 获取指标字段信息 请求体
/// <para>获取指标的字段基础信息</para>
/// <para>接口ID：7380276358332727297</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/performance-v2/metric_field/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_field%2fquery</para>
/// </summary>
public record PostPerformanceV2MetricFieldsQueryBodyDto
{
    /// <summary>
    /// <para>指标的字段 ID，不传则默认获取全部字段信息</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：0</para>
    /// </summary>
    [JsonPropertyName("field_ids")]
    public string[]? FieldIds { get; set; }
}
