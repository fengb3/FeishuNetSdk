namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 创建部门 请求体
/// <para>创建部门。</para>
/// <para>接口ID：7072646559953797122</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/organization-management/department/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fdepartment%2fcreate</para>
/// </summary>
public record PostCorehrV1DepartmentsBodyDto
{
    /// <summary>
    /// <para>子类型</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("sub_type")]
    public Enum? SubType { get; set; }

    /// <summary>
    /// <para>子类型</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：type_1</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>部门负责人</para>
    /// <para>必填：否</para>
    /// <para>示例值：6893013238632416776</para>
    /// </summary>
    [JsonPropertyName("manager")]
    public string? Manager { get; set; }

    /// <summary>
    /// <para>是否保密</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("is_confidential")]
    public bool? IsConfidential { get; set; }

    /// <summary>
    /// <para>层级关系，内层字段见实体</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("hiberarchy_common")]
    public PostCorehrV1DepartmentsBodyDtoHiberarchyCommon HiberarchyCommon { get; set; } = new();

    /// <summary>
    /// <para>层级关系，内层字段见实体</para>
    /// </summary>
    public record PostCorehrV1DepartmentsBodyDtoHiberarchyCommon
    {
        /// <summary>
        /// <para>上级组织 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：4719168654814483759</para>
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// <para>名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
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
            [JsonPropertyName("lang")]
            public string Lang { get; set; } = string.Empty;

            /// <summary>
            /// <para>名称信息的内容</para>
            /// <para>必填：是</para>
            /// <para>示例值：张三</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string Value { get; set; } = string.Empty;
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// <para>编码</para>
        /// <para>必填：否</para>
        /// <para>示例值：12456</para>
        /// </summary>
        [JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("description")]
        public I18n[]? Descriptions { get; set; }
    }

    /// <summary>
    /// <para>生效时间。</para>
    /// <para>注意：1. 部门的生效时间不可早于其上级部门的生效时间；2.时分秒必须为 00:00:00</para>
    /// <para>必填：是</para>
    /// <para>示例值：2020-05-01 00:00:00</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
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
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>成本中心id</para>
    /// <para>必填：否</para>
    /// <para>示例值：7142384817131652652</para>
    /// </summary>
    [JsonPropertyName("cost_center_id")]
    public string? CostCenterId { get; set; }

    /// <summary>
    /// <para>是否使用职务</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("staffing_model")]
    public Enum? StaffingModel { get; set; }
}
