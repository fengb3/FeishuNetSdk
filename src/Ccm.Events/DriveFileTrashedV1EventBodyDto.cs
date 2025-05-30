// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-09-01
//
// Last Modified By : yxr
// Last Modified On : 2024-09-01
// ************************************************************************
// <copyright file="DriveFileTrashedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>文件删除到回收站 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm.Events;
/// <summary>
/// 文件删除到回收站 事件体
/// <para>被订阅的文件被删除到回收站时，将触发此事件。</para>
/// <para>接口ID：7013346140632563740</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/event/list/delete-file-to-trash-can</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fevent%2fdelete-file-to-trash-can</para>
/// </summary>
public record DriveFileTrashedV1EventBodyDto() : EventBodyDto("drive.file.trashed_v1")
{
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
}
