using Newtonsoft.Json;
namespace FeishuNetSdk.Helpdesk;
/// <summary>
/// 获取知识库分类 响应体
/// <para>该接口用于获取知识库分类。</para>
/// <para>接口ID：6955768699896020994</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/helpdesk-v1/faq-management/category/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fhelpdesk-v1%2fcategory%2fget</para>
/// </summary>
public record GetHelpdeskV1CategoriesByIdResponseDto
{
    /// <summary>
    /// <para>知识库分类ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6948728206392295444</para>
    /// </summary>
    [JsonProperty("category_id")]
    public string CategoryId { get; set; } = string.Empty;

    /// <summary>
    /// <para>知识库分类ID，（旧版，请使用category_id）</para>
    /// <para>必填：是</para>
    /// <para>示例值：6948728206392295444</para>
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// <para>名称</para>
    /// <para>必填：是</para>
    /// <para>示例值：创建团队和邀请成员</para>
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>服务台ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：6939771743531696147</para>
    /// </summary>
    [JsonProperty("helpdesk_id")]
    public string HelpdeskId { get; set; } = string.Empty;

    /// <summary>
    /// <para>语言</para>
    /// <para>必填：否</para>
    /// <para>示例值：zh_cn</para>
    /// </summary>
    [JsonProperty("language")]
    public string? Language { get; set; }
}