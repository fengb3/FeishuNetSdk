// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-01-11
// ************************************************************************
// <copyright file="GetCorehrV1CustomFieldsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取自定义字段列表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 获取自定义字段列表 响应体
/// <para>根据对象的 API name，获取「飞书人事」具体对象下的自定义字段列表</para>
/// <para>接口ID：7112009113388122140</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/custom_field/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcustom_field%2fquery</para>
/// </summary>
public record GetCorehrV1CustomFieldsQueryResponseDto
{
    /// <summary>
    /// <para>自定义字段列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public CustomField[]? Items { get; set; }

    /// <summary>
    /// <para>自定义字段列表</para>
    /// </summary>
    public record CustomField
    {
        /// <summary>
        /// <para>自定义字段 API name，即自定义字段的唯一标识</para>
        /// <para>必填：否</para>
        /// <para>示例值：custom_field_33__c</para>
        /// </summary>
        [JsonPropertyName("custom_api_name")]
        public string? CustomApiName { get; set; }

        /// <summary>
        /// <para>自定义字段名称</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("name")]
        public CustomFieldName Name { get; set; } = new();

        /// <summary>
        /// <para>自定义字段名称</para>
        /// </summary>
        public record CustomFieldName
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>描述</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("description")]
        public NameSuffix Description { get; set; } = new();

        /// <summary>
        /// <para>描述</para>
        /// </summary>
        public record NameSuffix
        {
            /// <summary>
            /// <para>中文</para>
            /// <para>必填：否</para>
            /// <para>示例值：cn</para>
            /// </summary>
            [JsonPropertyName("zh_cn")]
            public string? ZhCn { get; set; }

            /// <summary>
            /// <para>英文</para>
            /// <para>必填：否</para>
            /// <para>示例值：en</para>
            /// </summary>
            [JsonPropertyName("en_us")]
            public string? EnUs { get; set; }
        }

        /// <summary>
        /// <para>是否启用</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_open")]
        public bool IsOpen { get; set; }

        /// <summary>
        /// <para>是否必填</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// <para>是否唯一</para>
        /// <para>必填：是</para>
        /// <para>示例值：true</para>
        /// </summary>
        [JsonPropertyName("is_unique")]
        public bool IsUnique { get; set; }

        /// <summary>
        /// <para>所属对象 apiname</para>
        /// <para>必填：是</para>
        /// <para>示例值：offboarding_info</para>
        /// </summary>
        [JsonPropertyName("object_api_name")]
        public string ObjectApiName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段类型</para>
        /// <para>**可选值有：**</para>
        /// <para>- 1：文本 Text，“文本”和“超链接”属于该类型</para>
        /// <para>- 2：布尔 Boolean</para>
        /// <para>- 3：数字 Number</para>
        /// <para>- 4：枚举 Enum，“单选”和“多选”属于该类型</para>
        /// <para>- 5：查找 Lookup，“人员（单选）”、“人员（多选）”及“人员档案管理”页面中用户添加的自定义分组属于该类型</para>
        /// <para>- 6：自动编码 Auto Number</para>
        /// <para>- 7：日期时间 Date Time</para>
        /// <para>- 8：附件 Attachment，“附件单选”和“附件多选”为该类型</para>
        /// <para>- 9：图片 Image</para>
        /// <para>- 10：计算字段 Calculated</para>
        /// <para>- 11：反向查找 Back Lookup</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// </summary>
        [JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// <para>字段类型配置信息，可以用来区分同一字段类型下的不同子类型。当前仅字段类型为「文本」「布尔」「数字」「枚举」「日期时间」「附件」「图片」时返回相应的配置信息，其余类型暂不返回</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("common_schema_config")]
        public CustomFieldCommonSchemaConfig? CommonSchemaConfig { get; set; }

        /// <summary>
        /// <para>字段类型配置信息，可以用来区分同一字段类型下的不同子类型。当前仅字段类型为「文本」「布尔」「数字」「枚举」「日期时间」「附件」「图片」时返回相应的配置信息，其余类型暂不返回</para>
        /// </summary>
        public record CustomFieldCommonSchemaConfig
        {
            /// <summary>
            /// <para>文本配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("text_field_setting")]
            public CustomFieldCommonSchemaConfigTextFieldSetting? TextFieldSetting { get; set; }

            /// <summary>
            /// <para>文本配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigTextFieldSetting
            {
                /// <summary>
                /// <para>是否多语言</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_multilingual")]
                public bool? IsMultilingual { get; set; }

                /// <summary>
                /// <para>是否多行</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_multiline")]
                public bool? IsMultiline { get; set; }

                /// <summary>
                /// <para>最大长度</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("max_length")]
                public int MaxLength { get; set; }

                /// <summary>
                /// <para>是否是“超链接”类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// </summary>
                [JsonPropertyName("is_url_type")]
                public bool? IsUrlType { get; set; }
            }

            /// <summary>
            /// <para>数字配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("number_field_setting")]
            public CustomFieldCommonSchemaConfigNumberFieldSetting? NumberFieldSetting { get; set; }

            /// <summary>
            /// <para>数字配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigNumberFieldSetting
            {
                /// <summary>
                /// <para>数字类型</para>
                /// <para>**可选值有：**</para>
                /// <para>- `1`：Percent 百分比（定点小数）</para>
                /// <para>- `2`：Integer 整数</para>
                /// <para>- `3`：Value 数值（定点小数）</para>
                /// <para>- `4`：Money 金额（定点小数）</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("number_field_type")]
                public int? NumberFieldType { get; set; }

                /// <summary>
                /// <para>小数点后的位数</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("decimal_places")]
                public int? DecimalPlaces { get; set; }

                /// <summary>
                /// <para>四舍五入规则</para>
                /// <para>**可选值有：**</para>
                /// <para>- `0`：Round 四舍五入</para>
                /// <para>- `1`：Ceil 向上舍入</para>
                /// <para>- `2`：Floor 向下舍入</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("round_type")]
                public int? RoundType { get; set; }

                /// <summary>
                /// <para>整数+小数总位数</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("decimal_total_places")]
                public int? DecimalTotalPlaces { get; set; }
            }

            /// <summary>
            /// <para>枚举配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("enum_field_setting")]
            public CustomFieldCommonSchemaConfigEnumFieldSetting? EnumFieldSetting { get; set; }

            /// <summary>
            /// <para>枚举配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigEnumFieldSetting
            {
                /// <summary>
                /// <para>枚举选项信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("enum_field_option_list")]
                public CommonSchemaOption[]? EnumFieldOptionLists { get; set; }

                /// <summary>
                /// <para>枚举选项信息</para>
                /// </summary>
                public record CommonSchemaOption
                {
                    /// <summary>
                    /// <para>枚举常量集 API name，即一组选项集合的唯一标识。系统预置的枚举常量集可在[枚举常量介绍](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)文档中查询到</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：custom_enum_option_33</para>
                    /// </summary>
                    [JsonPropertyName("api_name")]
                    public string? ApiName { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("name")]
                    public CommonSchemaOptionName? Name { get; set; }

                    /// <summary>
                    /// <para>选项名称</para>
                    /// </summary>
                    public record CommonSchemaOptionName
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：cn</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：en</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>选项描述</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("description")]
                    public NameSuffix? Description { get; set; }

                    /// <summary>
                    /// <para>选项描述</para>
                    /// </summary>
                    public record NameSuffix
                    {
                        /// <summary>
                        /// <para>中文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：cn</para>
                        /// </summary>
                        [JsonPropertyName("zh_cn")]
                        public string? ZhCn { get; set; }

                        /// <summary>
                        /// <para>英文</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：en</para>
                        /// </summary>
                        [JsonPropertyName("en_us")]
                        public string? EnUs { get; set; }
                    }

                    /// <summary>
                    /// <para>是否启用</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// </summary>
                    [JsonPropertyName("is_open")]
                    public bool? IsOpen { get; set; }
                }

                /// <summary>
                /// <para>是否为多选</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_multiple")]
                public bool? IsMultiple { get; set; }
            }

            /// <summary>
            /// <para>查找字段配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("lookup_field_setting")]
            public CustomFieldCommonSchemaConfigLookupFieldSetting? LookupFieldSetting { get; set; }

            /// <summary>
            /// <para>查找字段配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigLookupFieldSetting
            {
                /// <summary>
                /// <para>查找字段所引用对象的 API name。对于“人员（单选）”和“人员（多选）”，其值为 `employment`。可通过[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)接口传入此参数的值来查询自定义分组中定义的自定义字段</para>
                /// <para>必填：否</para>
                /// <para>示例值：employment</para>
                /// </summary>
                [JsonPropertyName("lookup_obj_api_name")]
                public string? LookupObjApiName { get; set; }

                /// <summary>
                /// <para>是否为多值。例如“人员（单选）字段”此属性为 false，而“人员（多选）”字段此属性为 true。</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_multiple")]
                public bool? IsMultiple { get; set; }
            }

            /// <summary>
            /// <para>日期时间配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("date_time_field_setting")]
            public CustomFieldCommonSchemaConfigDateTimeFieldSetting? DateTimeFieldSetting { get; set; }

            /// <summary>
            /// <para>日期时间配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigDateTimeFieldSetting
            {
                /// <summary>
                /// <para>时间类型枚举</para>
                /// <para>**可选值有：**</para>
                /// <para>- `1`：Date 日期，如 2020-01-01</para>
                /// <para>- `2`：Time 时间，如 11:52:00</para>
                /// <para>- `3`：DateTime 日期时间，如 2020-01-01 11:52:00</para>
                /// <para>- `4`：CusDateTime 时间戳</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("date_time_type")]
                public int? DateTimeType { get; set; }
            }

            /// <summary>
            /// <para>附件配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("attachment_field_setting")]
            public CustomFieldCommonSchemaConfigAttachmentFieldSetting? AttachmentFieldSetting { get; set; }

            /// <summary>
            /// <para>附件配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigAttachmentFieldSetting
            {
                /// <summary>
                /// <para>是否支持多个文件</para>
                /// <para>必填：否</para>
                /// <para>示例值：false</para>
                /// </summary>
                [JsonPropertyName("is_multiple")]
                public bool? IsMultiple { get; set; }

                /// <summary>
                /// <para>废弃属性，不建议使用，通常为空值</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("file_type")]
                public int? FileType { get; set; }
            }

            /// <summary>
            /// <para>图片配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("image_field_setting")]
            public CustomFieldCommonSchemaConfigImageFieldSetting? ImageFieldSetting { get; set; }

            /// <summary>
            /// <para>图片配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigImageFieldSetting
            {
                /// <summary>
                /// <para>图片类型枚举</para>
                /// <para>**可选值有：**</para>
                /// <para>- `1`：Avatar 头像</para>
                /// <para>- `2`：BadgePhoto 工卡照片</para>
                /// <para>- `3`：Logo 标志</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("image_type")]
                public int? ImageType { get; set; }

                /// <summary>
                /// <para>显示样式</para>
                /// <para>**可选值有：**</para>
                /// <para>- `1`：SquareImage 方形</para>
                /// <para>- `2`：RoundImage 圆形</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("display_style")]
                public int? DisplayStyle { get; set; }
            }

            /// <summary>
            /// <para>计算字段配置信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("calculated_field_setting")]
            public CustomFieldCommonSchemaConfigCalculatedFieldSetting? CalculatedFieldSetting { get; set; }

            /// <summary>
            /// <para>计算字段配置信息</para>
            /// </summary>
            public record CustomFieldCommonSchemaConfigCalculatedFieldSetting
            {
                /// <summary>
                /// <para>字段类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>最大值：255</para>
                /// <para>最小值：0</para>
                /// </summary>
                [JsonPropertyName("type")]
                public int Type { get; set; }
            }
        }

        /// <summary>
        /// <para>创建时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625542287</para>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string? CreateTime { get; set; }

        /// <summary>
        /// <para>更新时间，秒级时间戳</para>
        /// <para>必填：否</para>
        /// <para>示例值：1625542639</para>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string? UpdateTime { get; set; }
    }
}
