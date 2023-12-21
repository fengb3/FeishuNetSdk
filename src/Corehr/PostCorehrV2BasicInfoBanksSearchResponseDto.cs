namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询银行信息 响应体
/// <para>根据银行 ID 、银行名称查询银行信息</para>
/// <para>接口ID：7301516605753196547</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-bank%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoBanksSearchResponseDto
{
    /// <summary>
    /// <para>查询的银行信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public Bank[]? Items { get; set; }

    /// <summary>
    /// <para>查询的银行信息</para>
    /// </summary>
    public record Bank
    {
        /// <summary>
        /// <para>银行 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064135</para>
        /// </summary>
        [JsonPropertyName("bank_id")]
        public string? BankId { get; set; }

        /// <summary>
        /// <para>银行名称</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("bank_name")]
        public I18n[]? BankNames { get; set; }

        /// <summary>
        /// <para>银行名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>总行代码</para>
        /// <para>必填：否</para>
        /// <para>示例值：BKCH</para>
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string? BankCode { get; set; }

        /// <summary>
        /// <para>国家 / 地区 ID ，可通过[查询国家 / 地区信息](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-country_region/search) 接口查询</para>
        /// <para>必填：否</para>
        /// <para>示例值：6893014062142064133</para>
        /// </summary>
        [JsonPropertyName("country_region_id")]
        public string? CountryRegionId { get; set; }

        /// <summary>
        /// <para>状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：生效</item>
        /// <item>0：失效</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("status")]
        public int? Status { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }
}
