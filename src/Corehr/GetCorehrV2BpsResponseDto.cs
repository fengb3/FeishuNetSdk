using Newtonsoft.Json;
namespace FeishuNetSdk.Corehr;
/// <summary>
/// 获取 HRBP 列表 响应体
/// <para>获取 HRBP 列表。</para>
/// <para>接口ID：7261860942295564290</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/bp/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbp%2flist</para>
/// </summary>
public record GetCorehrV2BpsResponseDto
{
    /// <summary>
    /// <para>HRBP 信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public Bp[]? Items { get; set; }

    /// <summary>
    /// <para>HRBP 信息</para>
    /// </summary>
    public record Bp
    {
        /// <summary>
        /// <para>部门 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520852</para>
        /// </summary>
        [JsonProperty("department_id")]
        public string? DepartmentId { get; set; }

        /// <summary>
        /// <para>部门 HRBP 的雇佣 ID，不包括上级部门的 HRBP</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719456877659520852</para>
        /// </summary>
        [JsonProperty("hrbp_id")]
        public string? HrbpId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("has_more")]
    public bool? HasMore { get; set; }
}