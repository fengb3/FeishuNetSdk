namespace FeishuNetSdk.Im;
/// <summary>
/// 机器人单聊即时提醒 请求体
/// <para>可将机器人对话在消息列表中置顶展示，打开飞书首页即可处理重要任务。</para>
/// <para>接口ID：7350335258430799873</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/group/im-v2/feed_card/bot_time_sentive</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fgroup%2fim-v2%2ffeed_card%2fbot_time_sentive</para>
/// </summary>
public record PatchImV2FeedCardsBotTimeSentiveBodyDto
{
    /// <summary>
    /// <para>即时提醒状态（设置为 true 后，卡片在消息列表临时置顶；设置为 false，消息卡片不置顶）</para>
    /// <para>必填：是</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("time_sensitive")]
    public bool TimeSensitive { get; set; }

    /// <summary>
    /// <para>用户 ID 列表（ID 类型与 user_id_type 的取值一致。如果是商店应用，因不支持获取用户 user ID 权限，所以无法使用 user_id 类型的用户 ID）</para>
    /// <para>必填：是</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("user_ids")]
    public string[] UserIds { get; set; } = Array.Empty<string>();
}
