// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新自定义字段选项 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 更新自定义字段选项 请求体
/// <para>根据一个自定义字段的GUID和其选项的GUID，更新该选项的数据。要更新的字段必须是单选或者多选类型，且要更新的字段必须归属于该字段。</para>
/// <para>更新时，将`update_fields`字段中填写所有要修改的任务字段名，同时在`option`字段中填写要修改的字段的新值即可。`update_fields`支持的字段包括：</para>
/// <para>* `name`: 选项名称</para>
/// <para>* `color_index`: 选项的颜色索引值</para>
/// <para>* `is_hidden`: 是否从界面上隐藏</para>
/// <para>* `insert_before`: 将当前option放到同字段某个option之前的那个option_guid。</para>
/// <para>* `insert_after`: 将当前option放到同字段某个option之后的那个option_guid。</para>
/// <para>接口ID：7270765454292221954</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field-option/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field-option%2fpatch</para>
/// </summary>
public record PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidBodyDto
{
    /// <summary>
    /// <para>要更新的option数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("option")]
    public InputOption? Option { get; set; }

    /// <summary>
    /// <para>要更新的option数据</para>
    /// </summary>
    public record InputOption
    {
        /// <summary>
        /// <para>选项名称，最大50个字符</para>
        /// <para>必填：否</para>
        /// <para>示例值：高优</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>颜色索引值，支持0～54中的一个数字。</para>
        /// <para>必填：否</para>
        /// <para>示例值：10</para>
        /// <para>最大值：54</para>
        /// <para>最小值：0</para>
        /// </summary>
        [JsonPropertyName("color_index")]
        public int? ColorIndex { get; set; }

        /// <summary>
        /// <para>要放到某个option之前的option_guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：2bd905f8-ef38-408b-aa1f-2b2ad33b2913</para>
        /// </summary>
        [JsonPropertyName("insert_before")]
        public string? InsertBefore { get; set; }

        /// <summary>
        /// <para>要放到某个option之后的option_guid</para>
        /// <para>必填：否</para>
        /// <para>示例值：b13adf3c-cad6-4e02-8929-550c112b5633</para>
        /// </summary>
        [JsonPropertyName("insert_after")]
        public string? InsertAfter { get; set; }

        /// <summary>
        /// <para>是否隐藏</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// <para>默认值：false</para>
        /// </summary>
        [JsonPropertyName("is_hidden")]
        public bool? IsHidden { get; set; }
    }

    /// <summary>
    /// <para>要更新的字段名，支持</para>
    /// <para>* `name`: 选项名称</para>
    /// <para>* `color_index`: 选项的颜色索引值</para>
    /// <para>* `is_hidden`: 是否从界面上隐藏</para>
    /// <para>* `insert_before`: 将当前option放到同字段某个option之前。</para>
    /// <para>* `insert_after`: 将当前option放到同字段某个option之后。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：20</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("update_fields")]
    public string[]? UpdateFields { get; set; }
}
