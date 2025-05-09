// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostLingoV1FilesUploadBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>上传图片 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Baike;
/// <summary>
/// 上传图片 请求体
/// <para>词条图片资源上传。</para>
/// <para>接口ID：7249689905697013788</para>
/// <para>文档地址：https://open.feishu.cn/document/lingo-v1/file/upload</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2ffile%2fupload</para>
/// </summary>
public record PostLingoV1FilesUploadBodyDto
{
    /// <summary>
    /// <para>文件名称，当前仅支持上传图片且图片格式为以下六种：icon、bmp、gif、png、jpeg、webp</para>
    /// <para>必填：是</para>
    /// <para>示例值：示例图片.png</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}
