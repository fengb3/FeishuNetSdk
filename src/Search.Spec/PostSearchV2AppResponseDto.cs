using Newtonsoft.Json;
namespace FeishuNetSdk.Search.Spec;
/// <summary>
/// 搜索应用 响应体
/// <para>用户可以通过关键字搜索到可见应用，应用可见性与套件内搜索一致。</para>
/// <para>接口ID：7208771563588075523</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/search-v2/suite-search/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsearch-v2%2fapp%2fcreate</para>
/// </summary>
public record PostSearchV2AppResponseDto
{
    /// <summary>
    /// <para>app_id列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public string[]? Items { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}