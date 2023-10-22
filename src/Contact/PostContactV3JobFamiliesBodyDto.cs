using Newtonsoft.Json;
namespace FeishuNetSdk.Contact;
/// <summary>
/// 创建序列 请求体
/// <para>该接口用于创建租户内的序列信息。</para>
/// <para>接口ID：7194273514093412356</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/job_family/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fjob_family%2fcreate</para>
/// </summary>
public record PostContactV3JobFamiliesBodyDto
{
    /// <summary>
    /// <para>序列名称。1-100字符，支持中、英文及符号</para>
    /// <para>必填：是</para>
    /// <para>示例值：产品</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// <para>序列描述，描述序列详情信息</para>
    /// <para>必填：否</para>
    /// <para>示例值：负责产品策略制定的相关工作</para>
    /// </summary>
    [JsonProperty("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>上级序列ID。需是该租户的序列ID列表中的值，对应唯一的序列名称。</para>
    /// <para>必填：否</para>
    /// <para>示例值：mga5oa8ayjlpzjq</para>
    /// </summary>
    [JsonProperty("parent_job_family_id")]
    public string? ParentJobFamilyId { get; set; }

    /// <summary>
    /// <para>是否启用</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonProperty("status")]
    public bool Status { get; set; }

    /// <summary>
    /// <para>多语言序列名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("i18n_name")]
    public I18nContent[]? I18nNames { get; set; }

    /// <summary>
    /// <para>多语言序列名称</para>
    /// </summary>
    public record I18nContent
    {
        /// <summary>
        /// <para>语言版本</para>
        /// <para>必填：否</para>
        /// <para>示例值：zh_cn</para>
        /// </summary>
        [JsonProperty("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// <para>字段名</para>
        /// <para>必填：否</para>
        /// <para>示例值：多语言内容</para>
        /// </summary>
        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    /// <summary>
    /// <para>多语言描述</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("i18n_description")]
    public I18nContent[]? I18nDescriptions { get; set; }
}