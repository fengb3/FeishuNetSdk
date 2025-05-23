// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesBatchCreateResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增多个数据表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增多个数据表 响应体
/// <para>新增多个数据表，仅可指定数据表名称。最多支持新增 100 个数据表。</para>
/// <para>接口ID：6960166873968558083</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/batch_create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fbatch_create</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesBatchCreateResponseDto
{
    /// <summary>
    /// <para>table ids</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("table_ids")]
    public string[]? TableIds { get; set; }
}
