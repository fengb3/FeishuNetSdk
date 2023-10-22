using Newtonsoft.Json;
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 查询单个序列 响应体
/// <para>根据 ID 查询单个序列。</para>
/// <para>接口ID：7017707615191007235</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/job-management/job_family/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_family%2fget</para>
/// </summary>
public record GetCorehrV1JobFamiliesByJobFamilyIdResponseDto
{
    /// <summary>
    /// <para>序列信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("job_family")]
    public GetCorehrV1JobFamiliesByJobFamilyIdResponseDtoJobFamily? JobFamily { get; set; }

    /// <summary>
    /// <para>序列信息</para>
    /// </summary>
    public record GetCorehrV1JobFamiliesByJobFamilyIdResponseDtoJobFamily
    {
        /// <summary>
        /// <para>序列 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4698019107896524633</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonProperty("name")]
        public I18n[] Names { get; set; } = Array.Empty<I18n>();

        /// <summary>
        /// <para>名称</para>
        /// </summary>
        public record I18n
        {
            /// <summary>
            /// <para>名称信息的语言</para>
            /// <para>必填：是</para>
            /// <para>示例值：zh-CN</para>
            /// </summary>
            [JsonProperty("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>上级序列 ID，枚举值及详细信息可通过【批量查询序列】接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：4698020757495316313</para>
        /// </summary>
        [JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>生效时间</para>
        /// <para>必填：是</para>
        /// <para>示例值：2020-05-0100:00:00</para>
        /// </summary>
        [JsonProperty("effective_time")]
        public string EffectiveTime { get; set; } = string.Empty;

        /// <summary>
        /// <para>失效时间</para>
        /// <para>必填：否</para>
        /// <para>示例值：2020-05-0200:00:00</para>
        /// </summary>
        [JsonProperty("expiration_time")]
        public string? ExpirationTime { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：123456</para>
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("custom_fields")]
        public ObjectFieldData[]? CustomFields { get; set; }

        /// <summary>
        /// <para>自定义字段</para>
        /// </summary>
        public record ObjectFieldData
        {
            /// <summary>
            /// <para>字段名</para>
            /// <para>必填：是</para>
            /// <para>示例值：name</para>
            /// </summary>
            [JsonProperty("field_name")]
            public string FieldName { get; set; } = string.Empty;

            /// <summary>
            /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
            /// <para>必填：是</para>
            /// <para>示例值：\"Sandy\"</para>
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; } = string.Empty;
        }
    }
}