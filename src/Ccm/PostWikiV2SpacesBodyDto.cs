using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建知识空间 请求体
/// <para>此接口用于创建知识空间</para>
/// <para>接口ID：7023947709203922948</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace%2fcreate</para>
/// </summary>
public record PostWikiV2SpacesBodyDto
{
    /// <summary>
    /// <para>知识空间名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：知识空间</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>知识空间描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：知识空间描述</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }
}