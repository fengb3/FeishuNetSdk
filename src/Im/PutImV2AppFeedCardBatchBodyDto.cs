namespace FeishuNetSdk.Im;
/// <summary>
/// 更新应用消息流卡片 请求体
/// <para>该接口用于更新消息流卡片的头像、标题、预览、标签状态、按钮等信息</para>
/// <para>接口ID：7302258202712473628</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/app_feed_card-batch/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2fapp_feed_card-batch%2fupdate</para>
/// </summary>
public record PutImV2AppFeedCardBatchBodyDto
{
    /// <summary>
    /// <para>应用消息卡片</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("feed_cards")]
    public UserOpenAppFeedCardUpdater[]? FeedCards { get; set; }

    /// <summary>
    /// <para>应用消息卡片</para>
    /// </summary>
    public record UserOpenAppFeedCardUpdater
    {
        /// <summary>
        /// <para>应用消息卡片</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("app_feed_card")]
        public OpenAppFeedCard AppFeedCard { get; set; } = new();

        /// <summary>
        /// <para>应用消息卡片</para>
        /// </summary>
        public record OpenAppFeedCard
        {
            /// <summary>
            /// <para>业务 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：096e2927-40a6-41a3-9562-314d641d09ae</para>
            /// <para>最大长度：200</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("biz_id")]
            public string? BizId { get; set; }

            /// <summary>
            /// <para>主标题</para>
            /// <para>必填：否</para>
            /// <para>示例值：主标题</para>
            /// <para>最大长度：60</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            /// <summary>
            /// <para>头像 key</para>
            /// <para>必填：否</para>
            /// <para>示例值：v3_0041_007bca9f-67ba-4199-bf00-4031b12cf226</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("avatar_key")]
            public string? AvatarKey { get; set; }

            /// <summary>
            /// <para>预览信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：预览信息</para>
            /// <para>最大长度：120</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("preview")]
            public string? Preview { get; set; }

            /// <summary>
            /// <para>状态标签</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("status_label")]
            public OpenFeedStatusLabel? StatusLabel { get; set; }

            /// <summary>
            /// <para>状态标签</para>
            /// </summary>
            public record OpenFeedStatusLabel
            {
                /// <summary>
                /// <para>标签文字</para>
                /// <para>必填：是</para>
                /// <para>示例值：标签文字</para>
                /// <para>最大长度：20</para>
                /// <para>最小长度：1</para>
                /// </summary>
                [JsonPropertyName("text")]
                public string Text { get; set; } = string.Empty;

                /// <summary>
                /// <para>标签类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：primary</para>
                /// <para>可选值：<list type="bullet">
                /// <item>primary：主类型</item>
                /// <item>secondary：次要类型</item>
                /// <item>success：成功类型</item>
                /// <item>danger：危险类型</item>
                /// </list></para>
                /// <para>默认值：primary</para>
                /// </summary>
                [JsonPropertyName("type")]
                public string Type { get; set; } = string.Empty;
            }

            /// <summary>
            /// <para>交互按钮</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("buttons")]
            public OpenAppFeedCardButtons? Buttons { get; set; }

            /// <summary>
            /// <para>交互按钮</para>
            /// </summary>
            public record OpenAppFeedCardButtons
            {
                /// <summary>
                /// <para>按钮组合</para>
                /// <para>必填：是</para>
                /// <para>最大长度：2</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("buttons")]
                public OpenAppFeedCardButton[] Buttons { get; set; } = Array.Empty<OpenAppFeedCardButton>();

                /// <summary>
                /// <para>按钮组合</para>
                /// </summary>
                public record OpenAppFeedCardButton
                {
                    /// <summary>
                    /// <para>跳转 URL</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("multi_url")]
                    public OpenAppFeedCardUrl? MultiUrl { get; set; }

                    /// <summary>
                    /// <para>跳转 URL</para>
                    /// </summary>
                    public record OpenAppFeedCardUrl
                    {
                        /// <summary>
                        /// <para>默认 URL</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://www.feishu.cn/</para>
                        /// <para>最大长度：700</para>
                        /// </summary>
                        [JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// <para>Android 平台 URL</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://www.feishu.cn/</para>
                        /// <para>最大长度：700</para>
                        /// </summary>
                        [JsonPropertyName("android_url")]
                        public string? AndroidUrl { get; set; }

                        /// <summary>
                        /// <para>iOS 平台 URL</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://www.feishu.cn/</para>
                        /// <para>最大长度：700</para>
                        /// </summary>
                        [JsonPropertyName("ios_url")]
                        public string? IosUrl { get; set; }

                        /// <summary>
                        /// <para>PC URL</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：https://www.feishu.cn/</para>
                        /// <para>最大长度：700</para>
                        /// </summary>
                        [JsonPropertyName("pc_url")]
                        public string? PcUrl { get; set; }
                    }

                    /// <summary>
                    /// <para>交互类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：url_page</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>url_page：URL 页面</item>
                    /// <item>webhook：回调</item>
                    /// </list></para>
                    /// </summary>
                    [JsonPropertyName("action_type")]
                    public string ActionType { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文字</para>
                    /// <para>必填：是</para>
                    /// </summary>
                    [JsonPropertyName("text")]
                    public OpenAppFeedCardText Text { get; set; } = new();

                    /// <summary>
                    /// <para>文字</para>
                    /// </summary>
                    public record OpenAppFeedCardText
                    {
                        /// <summary>
                        /// <para>文本</para>
                        /// <para>必填：是</para>
                        /// <para>示例值：文本</para>
                        /// <para>最大长度：30</para>
                        /// <para>最小长度：1</para>
                        /// </summary>
                        [JsonPropertyName("text")]
                        public string Text { get; set; } = string.Empty;
                    }

                    /// <summary>
                    /// <para>按钮类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：default</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>default：默认</item>
                    /// <item>primary：主要</item>
                    /// <item>success：成功</item>
                    /// </list></para>
                    /// <para>默认值：default</para>
                    /// </summary>
                    [JsonPropertyName("button_type")]
                    public string? ButtonType { get; set; }

                    /// <summary>
                    /// <para>action 字典</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：{"foo": "bar"}</para>
                    /// </summary>
                    [JsonPropertyName("action_map")]
                    public object? ActionMap { get; set; }
                }
            }

            /// <summary>
            /// <para>跳转链接</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("link")]
            public OpenAppFeedLink? Link { get; set; }

            /// <summary>
            /// <para>跳转链接</para>
            /// </summary>
            public record OpenAppFeedLink
            {
                /// <summary>
                /// <para>链接</para>
                /// <para>必填：否</para>
                /// <para>示例值：https://www.feishu.cn/</para>
                /// <para>最大长度：700</para>
                /// </summary>
                [JsonPropertyName("link")]
                public string? Link { get; set; }
            }

            /// <summary>
            /// <para>即时提醒状态，true-打开，false-关闭</para>
            /// <para>必填：否</para>
            /// <para>示例值：false</para>
            /// <para>默认值：false</para>
            /// </summary>
            [JsonPropertyName("time_sensitive")]
            public bool? TimeSensitive { get; set; }

            /// <summary>
            /// <para>通知设置，当前可设置通知是否关闭，为空时默认进行通知</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("notify")]
            public AppFeedNotify? Notify { get; set; }

            /// <summary>
            /// <para>通知设置，当前可设置通知是否关闭，为空时默认进行通知</para>
            /// </summary>
            public record AppFeedNotify
            {
                /// <summary>
                /// <para>是否关闭通知</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("close_notify")]
                public bool? CloseNotify { get; set; }

                /// <summary>
                /// <para>自定义语音播报文本内容</para>
                /// <para>必填：否</para>
                /// <para>示例值：您有新的订单</para>
                /// <para>最大长度：20</para>
                /// </summary>
                [JsonPropertyName("custom_sound_text")]
                public string? CustomSoundText { get; set; }

                /// <summary>
                /// <para>是否播报自定义语音</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonPropertyName("with_custom_sound")]
                public bool? WithCustomSound { get; set; }
            }
        }

        /// <summary>
        /// <para>用户 id</para>
        /// <para>必填：是</para>
        /// <para>示例值：ou_a0553eda9014c201e6969b478895c230</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// <para>更新字段列表</para>
        /// <para>必填：是</para>
        /// <para>最大长度：20</para>
        /// <para>最小长度：1</para>
        /// </summary>
        [JsonPropertyName("update_fields")]
        public string[] UpdateFields { get; set; } = Array.Empty<string>();
    }
}
