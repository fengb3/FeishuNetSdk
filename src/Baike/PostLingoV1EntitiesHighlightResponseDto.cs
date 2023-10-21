using Newtonsoft.Json;
namespace FeishuNetSdk.Baike;
/// <summary>
/// 词条高亮 响应体
/// <para>传入一句话，智能识别句中对应的词条，并返回词条位置和 entity_id，可在外部系统中快速实现词条智能高亮。</para>
/// <para>接口ID：7249689905697210396</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/lingo-v1/entity/highlight</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2flingo-v1%2fentity%2fhighlight</para>
/// </summary>
public record PostLingoV1EntitiesHighlightResponseDto
{
    /// <summary>
    /// <para>识别到的词条信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("phrases")]
    public Phrase[]? Phrases { get; set; }

    /// <summary>
    /// <para>识别到的词条信息</para>
    /// </summary>
    public record Phrase
    {
        /// <summary>
        /// <para>识别到的关键词</para>
        /// <para>必填：是</para>
        /// <para>示例值：词典</para>
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// <para>对应的词条 ID</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("entity_ids")]
        public string[] EntityIds { get; set; } = Array.Empty<string>();

        /// <summary>
        /// <para>词条所在位置</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("span")]
        public PhraseSpan Span { get; set; } = new();

        /// <summary>
        /// <para>词条所在位置</para>
        /// </summary>
        public record PhraseSpan
        {
            /// <summary>
            /// <para>关键词开始位置，从 0 开始计数（编码格式采用 utf-8）</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// </summary>
            [JsonProperty("start")]
            public int Start { get; set; }

            /// <summary>
            /// <para>关键词结束位置，从 0 开始计数（编码格式采用 utf-8）</para>
            /// <para>必填：是</para>
            /// <para>示例值：2</para>
            /// </summary>
            [JsonProperty("end")]
            public int End { get; set; }
        }
    }
}
