using Newtonsoft.Json;
namespace FeishuNetSdk.Vc;
/// <summary>
/// 查询会议室层级列表 响应体
/// <para>该接口用来查询某个会议室层级下的子层级列表。</para>
/// <para>接口ID：7160517357592117251</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/room_level/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2froom_level%2flist</para>
/// </summary>
public record GetVcV1RoomLevelsResponseDto
{
    /// <summary>
    /// <para>会议室层级列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("items")]
    public RoomLevel[]? Items { get; set; }

    /// <summary>
    /// <para>会议室层级列表</para>
    /// </summary>
    public record RoomLevel
    {
        /// <summary>
        /// <para>层级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：层级ID</para>
        /// </summary>
        [JsonProperty("room_level_id")]
        public string? RoomLevelId { get; set; }

        /// <summary>
        /// <para>层级名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：测试层级</para>
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>父层级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：omb_4ad1a2c7a2fbc5fc9570f38456931293</para>
        /// </summary>
        [JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>层级路径</para>
        /// <para>必填：否</para>
        /// <para>示例值：[omb_8d020b12fe49e82847c2af3c193d5754,omb_8d020b12fe49e82847c2af3c193d5754]</para>
        /// </summary>
        [JsonProperty("path")]
        public string[]? Path { get; set; }

        /// <summary>
        /// <para>是否有子层级</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonProperty("has_child")]
        public bool? HasChild { get; set; }

        /// <summary>
        /// <para>自定义层级ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：10000</para>
        /// </summary>
        [JsonProperty("custom_group_id")]
        public string? CustomGroupId { get; set; }
    }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：10</para>
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