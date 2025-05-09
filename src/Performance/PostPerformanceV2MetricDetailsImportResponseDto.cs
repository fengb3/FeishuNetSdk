// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-02
//
// Last Modified By : yxr
// Last Modified On : 2024-07-02
// ************************************************************************
// <copyright file="PostPerformanceV2MetricDetailsImportResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>录入被评估人关键指标数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Performance;
/// <summary>
/// 录入被评估人关键指标数据 响应体
/// <para>批量录入指定周期中被评估人的关键指标数据。</para>
/// <para>接口ID：7380276358332694529</para>
/// <para>文档地址：https://open.feishu.cn/document/performance-v1/metric_detail/import</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fperformance-v2%2fmetric_detail%2fimport</para>
/// </summary>
public record PostPerformanceV2MetricDetailsImportResponseDto
{
    /// <summary>
    /// <para>导入记录 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7241404194141224979</para>
    /// </summary>
    [JsonPropertyName("import_record_id")]
    public string? ImportRecordId { get; set; }
}
