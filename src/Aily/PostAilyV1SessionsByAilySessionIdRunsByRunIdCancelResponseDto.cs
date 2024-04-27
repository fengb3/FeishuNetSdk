namespace FeishuNetSdk.Aily;
/// <summary>
/// 取消运行 响应体
/// <para>该 API 用于取消某个飞书智能伙伴应用的运行（Run）。</para>
/// <para>接口ID：7358047310868217860</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/aily-v1/aily_session-run/cancel</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2faily-v1%2faily_session-run%2fcancel</para>
/// </summary>
public record PostAilyV1SessionsByAilySessionIdRunsByRunIdCancelResponseDto
{
    /// <summary>
    /// <para>运行信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("run")]
    public PostAilyV1SessionsByAilySessionIdRunsByRunIdCancelResponseDtoRun? Run { get; set; }

    /// <summary>
    /// <para>运行信息</para>
    /// </summary>
    public record PostAilyV1SessionsByAilySessionIdRunsByRunIdCancelResponseDtoRun
    {
        /// <summary>
        /// <para>运行 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：run_4dfrxvctjqzzj</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：5</para>
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// <para>运行的创建时间，毫秒时间戳</para>
        /// <para>必填：是</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：13</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } = string.Empty;

        /// <summary>
        /// <para>应用 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：spring_xxx__c</para>
        /// <para>最大长度：64</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// <para>会话 ID</para>
        /// <para>必填：是</para>
        /// <para>示例值：session_4dfunz7sp1g8m</para>
        /// <para>最大长度：32</para>
        /// <para>最小长度：9</para>
        /// </summary>
        [JsonPropertyName("session_id")]
        public string SessionId { get; set; } = string.Empty;

        /// <summary>
        /// <para>状态</para>
        /// <para>必填：是</para>
        /// <para>示例值：IN_PROGRESS</para>
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// <para>开始时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：13</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("started_at")]
        public string? StartedAt { get; set; }

        /// <summary>
        /// <para>结束时间，毫秒时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1711975665710</para>
        /// <para>最大长度：13</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("ended_at")]
        public string? EndedAt { get; set; }

        /// <summary>
        /// <para>失败时的错误信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("error")]
        public RunError? Error { get; set; }

        /// <summary>
        /// <para>失败时的错误信息</para>
        /// </summary>
        public record RunError
        {
            /// <summary>
            /// <para>错误码</para>
            /// <para>必填：是</para>
            /// <para>示例值：sp_ec_sm_900101</para>
            /// <para>最大长度：32</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("code")]
            public string Code { get; set; } = string.Empty;

            /// <summary>
            /// <para>错误信息</para>
            /// <para>必填：是</para>
            /// <para>示例值：技能不存在或已删除</para>
            /// <para>最大长度：64</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("message")]
            public string Message { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>其他透传信息</para>
        /// <para>必填：否</para>
        /// <para>示例值：{}</para>
        /// <para>最大长度：255</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("metadata")]
        public string? Metadata { get; set; }
    }
}
