using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 更新回复 请求体
/// <para>更新云文档中的某条回复。</para>
/// <para>接口ID：6955017385137733633</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/CommentAPI/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile-comment-reply%2fupdate</para>
/// </summary>
public record PutDriveV1FilesByFileTokenCommentsByCommentIdRepliesByReplyIdBodyDto
{
    /// <summary>
    /// <para>回复内容</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("content")]
    public ReplyContent Content { get; set; } = new();

    public record ReplyContent
    {
        /// <summary>
        /// <para>回复的内容</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("elements")]
        public ReplyElement[] Elements { get; set; } = Array.Empty<ReplyElement>();

        public record ReplyElement
        {
            /// <summary>
            /// <para>回复的内容元素</para>
            /// <para>**示例值**："text_run"</para>
            /// <para>**可选值有**：</para>
            /// <para>text_run:普通文本,docs_link:at 云文档链接,person:at 联系人</para>
            /// <para>必填：是</para>
            /// <para>可选值：<list type="bullet">
            /// <item>text_run：普通文本</item>
            /// <item>docs_link：at云文档链接</item>
            /// <item>person：at联系人</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("type")]
            public string Type { get; set; } = string.Empty;

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("text_run")]
            public TextRunSuffix? TextRun { get; set; }

            public record TextRunSuffix
            {
                /// <summary>
                /// <para>回复 普通文本</para>
                /// <para>**示例值**："comment text"</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonProperty("text")]
                public string Text { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("docs_link")]
            public DocsLinkSuffix? DocsLink { get; set; }

            public record DocsLinkSuffix
            {
                /// <summary>
                /// <para>回复 at云文档</para>
                /// <para>**示例值**："https://bytedance.feishu.cn/docs/doccnHh7U87HOFpii5u5Gabcef"</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>文本内容</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("person")]
            public PersonSuffix? Person { get; set; }

            public record PersonSuffix
            {
                /// <summary>
                /// <para>回复 at联系人</para>
                /// <para>**示例值**："ou_cc19b2bfb93f8a44db4b4d6eababcef"</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonProperty("user_id")]
                public string UserId { get; set; } = string.Empty;
            }

        }

    }
}
