// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostContactV3DepartmentsSearchBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>搜索部门 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Contact;
/// <summary>
/// 搜索部门 请求体
/// <para>调用该接口以用户身份通过部门名称关键词查询可见部门的信息，包括部门的 ID、父部门、负责人以及状态等。</para>
/// <para>接口ID：6943913881476841499</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fsearch</para>
/// </summary>
public record PostContactV3DepartmentsSearchBodyDto
{
    /// <summary>
    /// <para>搜索关键词，匹配字段为部门名称（不支持匹配部门国际化名称）。</para>
    /// <para>必填：是</para>
    /// <para>示例值：DemoName</para>
    /// </summary>
    [JsonPropertyName("query")]
    public string Query { get; set; } = string.Empty;
}
