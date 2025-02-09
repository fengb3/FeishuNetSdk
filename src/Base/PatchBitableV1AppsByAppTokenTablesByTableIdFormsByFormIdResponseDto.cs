// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新表单元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新表单元数据 响应体
/// <para>更新表单视图中的元数据，包括表单名称、描述、是否共享等。</para>
/// <para>接口ID：7119425455108669468</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/form/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-form%2fpatch</para>
/// </summary>
public record PatchBitableV1AppsByAppTokenTablesByTableIdFormsByFormIdResponseDto
{
    /// <summary>
    /// <para>表单元数据信息</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("form")]
    public AppTableForm Form { get; set; } = new();

    /// <summary>
    /// <para>表单元数据信息</para>
    /// </summary>
    public record AppTableForm
    {
        /// <summary>
        /// <para>表单名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：表单</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>表单描述</para>
        /// <para>必填：否</para>
        /// <para>示例值：表单描述</para>
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// <para>是否开启共享</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("shared")]
        public bool? Shared { get; set; }

        /// <summary>
        /// <para>填写表单的 URL 链接。若开启共享，将返回该值</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.feishu.cn/share/base/shrcnCy1KAlpahNotmhRn1abcde</para>
        /// </summary>
        [JsonPropertyName("shared_url")]
        public string? SharedUrl { get; set; }

        /// <summary>
        /// <para>分享范围限制</para>
        /// <para>必填：否</para>
        /// <para>示例值：tenant_editable</para>
        /// <para>可选值：<list type="bullet">
        /// <item>off：仅邀请的人可填写</item>
        /// <item>tenant_editable：组织内获得链接的人可填写</item>
        /// <item>anyone_editable：互联网上获得链接的人可填写</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("shared_limit")]
        public string? SharedLimit { get; set; }

        /// <summary>
        /// <para>填写次数是否限制为一次</para>
        /// <para>必填：否</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("submit_limit_once")]
        public bool? SubmitLimitOnce { get; set; }
    }
}
