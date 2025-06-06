// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-11
//
// Last Modified By : yxr
// Last Modified On : 2025-04-11
// ************************************************************************
// <copyright file="PatchMailV1UserMailboxesByUserMailboxIdMailContactsByMailContactIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>修改邮箱联系人信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Mail;
/// <summary>
/// 修改邮箱联系人信息 请求体
/// <para>修改一个邮箱联系人的信息</para>
/// <para>接口ID：7270360193791901697</para>
/// <para>文档地址：https://open.feishu.cn/document/mail-v1/user_mailbox-mail_contact/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fmail-v1%2fuser_mailbox-mail_contact%2fpatch</para>
/// </summary>
public record PatchMailV1UserMailboxesByUserMailboxIdMailContactsByMailContactIdBodyDto
{
    /// <summary>
    /// <para>联系人姓名</para>
    /// <para>必填：是</para>
    /// <para>示例值：张三</para>
    /// <para>最大长度：64</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>联系人公司</para>
    /// <para>必填：否</para>
    /// <para>示例值：张三科技有限公司</para>
    /// <para>最大长度：64</para>
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// <para>联系人手机号</para>
    /// <para>必填：否</para>
    /// <para>示例值：19912341234</para>
    /// <para>最大长度：40</para>
    /// </summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    /// <summary>
    /// <para>联系人邮箱</para>
    /// <para>必填：否</para>
    /// <para>示例值：zhangsan@example.com</para>
    /// <para>最大长度：319</para>
    /// </summary>
    [JsonPropertyName("mail_address")]
    public string? MailAddress { get; set; }

    /// <summary>
    /// <para>联系人标签</para>
    /// <para>必填：否</para>
    /// <para>示例值：朋友</para>
    /// <para>最大长度：64</para>
    /// </summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>
    /// <para>联系人备注</para>
    /// <para>必填：否</para>
    /// <para>示例值：飞书发布会认识</para>
    /// <para>最大长度：1000</para>
    /// </summary>
    [JsonPropertyName("remark")]
    public string? Remark { get; set; }

    /// <summary>
    /// <para>联系人职位</para>
    /// <para>必填：否</para>
    /// <para>示例值：CEO</para>
    /// <para>最大长度：64</para>
    /// </summary>
    [JsonPropertyName("position")]
    public string? Position { get; set; }
}
