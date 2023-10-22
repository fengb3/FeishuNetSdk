using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 创建推送 响应体
/// <para>调用接口创建推送，创建成功后为草稿状态。</para>
/// <para>接口ID：6999529163292639234</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/notification/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fnotification%2fcreate</para>
/// </summary>
public record PostHelpdeskV1NotificationsResponseDto
{
    /// <summary>
    /// <para>创建成功后的唯一id</para>
    /// <para>必填：否</para>
    /// <para>示例值：6985032626234982420</para>
    /// </summary>
    [JsonProperty("notification_id")]
    public string? NotificationId { get; set; }

    /// <summary>
    /// <para>当前状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// </summary>
    [JsonProperty("status")]
    public int? Status { get; set; }
}