using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取订阅状态 请求体
/// <para>根据订阅ID获取该订阅的状态</para>
/// <para>接口ID：7065964758428516380</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs-assistant/file-subscription/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-subscription%2fget</para>
/// </summary>
public record GetDriveV1FilesByFileTokenSubscriptionsBySubscriptionIdBodyDto
{
    /// <summary>
    /// <para>文档类型</para>
    /// <para>必填：是</para>
    /// <para>示例值：doc</para>
    /// <para>可选值：<list type="bullet">
    /// <item>doc：旧版文档</item>
    /// <item>docx：新版文档</item>
    /// <item>wiki：云空间</item>
    /// </list></para>
    /// </summary>
    [JsonProperty("file_type")]
    public string FileType { get; set; } = string.Empty;
}