// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-12-08
//
// Last Modified By : yxr
// Last Modified On : 2024-12-08
// ************************************************************************
// <copyright file="PostHireV1TalentsRemoveToFolderResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>将人才从指定文件夹移除 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 将人才从指定文件夹移除 响应体
/// <para>根据人才 ID 列表将人才从指定文件夹移除。</para>
/// <para>接口ID：7418831232862617601</para>
/// <para>文档地址：https://open.feishu.cn/document/hire-v1/candidate-management/talent/remove_to_folder</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2ftalent%2fremove_to_folder</para>
/// </summary>
public record PostHireV1TalentsRemoveToFolderResponseDto
{
    /// <summary>
    /// <para>已成功移除的人才 ID 列表，详情请查看：[获取人才信息](https://open.feishu.cn/document/ukTMukTMukTM/uMzM1YjLzMTN24yMzUjN/hire-v1/talent/get)</para>
    /// <para>必填：否</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("talent_id_list")]
    public string[]? TalentIdList { get; set; }

    /// <summary>
    /// <para>文件夹 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7039620186502138156</para>
    /// </summary>
    [JsonPropertyName("folder_id")]
    public string? FolderId { get; set; }
}
