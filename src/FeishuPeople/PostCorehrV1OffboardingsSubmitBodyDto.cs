// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-26
//
// Last Modified By : yxr
// Last Modified On : 2024-06-26
// ************************************************************************
// <copyright file="PostCorehrV1OffboardingsSubmitBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>操作员工离职 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 操作员工离职 请求体
/// <para>该接口用于发起员工离职。若发起成功，会生成一条员工的离职数据，同时产生相应的事件。参考[离职申请状态变更](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/offboarding/events/status_updated)</para>
/// <para>接口ID：7097044451155214340</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/offboarding/submit</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2foffboarding%2fsubmit</para>
/// </summary>
public record PostCorehrV1OffboardingsSubmitBodyDto
{
    /// <summary>
    /// <para>离职方式，目前只支持直接离职</para>
    /// <para>必填：是</para>
    /// <para>示例值：1</para>
    /// <para>可选值：<list type="bullet">
    /// <item>1：直接离职</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("offboarding_mode")]
    public int OffboardingMode { get; set; }

    /// <summary>
    /// <para>离职员工 ID。ID类型与查询参数 user_id_type取值一致：</para>
    /// <para>1、当user_id_type取值为open_id时，ID获取方式参考[如何获取自己的Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>2、当user_id_type取值为user_id时，ID获取方式参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>3、当user_id_type取值为union_id时，ID获取方式参考[如何获取自己的 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)。</para>
    /// <para>4、当user_id_type取值为people_corehr_id时，先参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)获取User ID。然后通过[ID 转换](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)获取雇佣ID。v1/common_data-id/convert)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：6982509313466189342</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>离职日期，入参格式应为YYYY-MM-DD</para>
    /// <para>必填：是</para>
    /// <para>示例值：2022-05-18</para>
    /// </summary>
    [JsonPropertyName("offboarding_date")]
    public string OffboardingDate { get; set; } = string.Empty;

    /// <summary>
    /// <para>离职原因，可通过接口</para>
    /// <para>[【查询员工离职原因列表】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/offboarding/query)获取</para>
    /// <para>必填：是</para>
    /// <para>示例值：reason_for_offboarding_option8</para>
    /// </summary>
    [JsonPropertyName("offboarding_reason_unique_identifier")]
    public string OffboardingReasonUniqueIdentifier { get; set; } = string.Empty;

    /// <summary>
    /// <para>离职原因说明，长度限制6000个字符，该字段允许为空</para>
    /// <para>必填：否</para>
    /// <para>示例值：离职原因说明</para>
    /// </summary>
    [JsonPropertyName("offboarding_reason_explanation")]
    public string? OffboardingReasonExplanation { get; set; }

    /// <summary>
    /// <para>操作发起人 ID。ID类型与查询参数 user_id_type取值一致：</para>
    /// <para>1、当user_id_type取值为open_id时，ID获取方式参考[如何获取自己的Open ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)。</para>
    /// <para>2、当user_id_type取值为user_id时，ID获取方式参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)。</para>
    /// <para>3、当user_id_type取值为union_id时，ID获取方式参考[如何获取自己的 Union ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id)。</para>
    /// <para>4、当user_id_type取值为people_corehr_id时，先参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)获取User ID。然后通过[ID 转换](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)获取雇佣ID。</para>
    /// <para>注意：</para>
    /// <para>1.只有操作发起人可以撤销流程</para>
    /// <para>2.为空时，默认系统发起人</para>
    /// <para>必填：否</para>
    /// <para>示例值：6982509313466189341</para>
    /// </summary>
    [JsonPropertyName("initiator_id")]
    public string? InitiatorId { get; set; }

    /// <summary>
    /// <para>是否加入离职屏蔽名单</para>
    /// <para>注意：</para>
    /// <para>1.取值为true时，屏蔽原因（block_reason）为必填。</para>
    /// <para>2.取值为false时，不允许填写屏蔽原因（block_reason）和屏蔽原因说明（block_reason_explanation）。</para>
    /// <para>3.取值为空时，不允许填写屏蔽原因（block_reason）和屏蔽原因说明（block_reason_explanation）。</para>
    /// <para>4.操作离职时如果选择加入屏蔽名单，只有当员工离职生效后才会进入到屏蔽名单。</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("add_block_list")]
    public bool? AddBlockList { get; set; }

    /// <summary>
    /// <para>屏蔽原因</para>
    /// <para>注意：</para>
    /// <para>1.该字段取值于 [人员档案配置](https://people.feishu.cn/people/hr-settings/profile) &gt; 信息配置 &gt; 离职信息 的屏蔽原因字段选项集。</para>
    /// <para>2.枚举字段值也可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，参考接口返回的 字段详情 &gt; 字段类型配置信息 &gt; 选项配置信息 &gt; 选项信息 &gt; 枚举常量集 API name</para>
    /// <para>3.该字段是否必填取决于是否加入离职屏蔽名单(add_block_list)</para>
    /// <para>必填：否</para>
    /// <para>示例值：红线</para>
    /// </summary>
    [JsonPropertyName("block_reason")]
    public string? BlockReason { get; set; }

    /// <summary>
    /// <para>屏蔽原因说明，该字段允许为空</para>
    /// <para>必填：否</para>
    /// <para>示例值：xx 年 xx 月 xx 日因 xx 原因红线</para>
    /// </summary>
    [JsonPropertyName("block_reason_explanation")]
    public string? BlockReasonExplanation { get; set; }

    /// <summary>
    /// <para>离职自定义字段。</para>
    /// <para>注意：可填写的字段范围参考[人员档案配置](https://people.feishu.cn/people/hr-settings/profile) &gt; 信息配置 &gt; 离职信息 中的自定义字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>离职自定义字段。</para>
    /// <para>注意：可填写的字段范围参考[人员档案配置](https://people.feishu.cn/people/hr-settings/profile) &gt; 信息配置 &gt; 离职信息 中的自定义字段</para>
    /// </summary>
    public record ObjectFieldData
    {
        /// <summary>
        /// <para>字段唯一标识</para>
        /// <para>注意：</para>
        /// <para>1.该字段取值于[人员档案配置](https://people.feishu.cn/people/hr-settings/profile) &gt; 信息配置 &gt; 离职信息 中各字段的字段编码</para>
        /// <para>2.该字段也可以通过[获取自定义字段列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/query)获取</para>
        /// <para>必填：是</para>
        /// <para>示例值：name</para>
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; } = string.Empty;

        /// <summary>
        /// <para>字段值，是json转义后的字符串，根据元数据定义不同，字段格式不同(如123, 123.23, "true", [\"id1\",\"id2\"], "2006-01-02 15:04:05")。</para>
        /// <para>注意：</para>
        /// <para>1.枚举字段的枚举值取值于[人员档案配置](https://people.feishu.cn/people/hr-settings/profile) &gt; 信息配置 &gt; 离职信息 对应字段选项集的选项编码。</para>
        /// <para>2.枚举字段值也可通过[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)获取，参考接口返回的 字段详情 &gt; 字段类型配置信息 &gt; 选项配置信息 &gt; 选项信息 &gt; 枚举常量集 API name</para>
        /// <para>3.人员字段目前只支持传入员工的雇佣ID。先参考[如何获取自己的 User ID](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)获取User ID。然后通过[ID 转换](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/common_data-id/convert)获取雇佣ID。</para>
        /// <para>4.暂不支持填写附件类型字段。</para>
        /// <para>必填：是</para>
        /// <para>示例值：\"Sandy\"</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }
}
