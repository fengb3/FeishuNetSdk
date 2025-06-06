// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="DriveFilePermissionMemberRemovedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文件协作者移除 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Events;
/// <summary>
/// 文件协作者移除 事件体
/// <para>移除用户或群作为文件协作者时将触发此事件。</para>
/// <para>接口ID：7013340088257544220</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/event/list/file-collaborator-remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fevent%2ffile-collaborator-remove</para>
/// </summary>
public record DriveFilePermissionMemberRemovedV1EventBodyDto() : EventBodyDto("drive.file.permission_member_removed_v1")
{
    /// <summary>
    /// <para>移除的群 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("chat_list")]
    public string[]? ChatList { get; set; }

    /// <summary>
    /// <para>云文档类型，支持以下枚举：</para>
    /// <para>- doc：旧版文档。已不推荐使用</para>
    /// <para>- docx：新版文档</para>
    /// <para>- sheet：电子表格</para>
    /// <para>- bitable：多维表格</para>
    /// <para>- slides：幻灯片</para>
    /// <para>- file：文件</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_type")]
    public string? FileType { get; set; }

    /// <summary>
    /// <para>云文档 token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("file_token")]
    public string? FileToken { get; set; }

    /// <summary>
    /// <para>操作人 ID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("operator_id")]
    public UserIdSuffix? OperatorId { get; set; }

    /// <summary>
    /// <para>移除的用户 ID 列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_list")]
    public UserIdSuffix[]? UserList { get; set; }
}
