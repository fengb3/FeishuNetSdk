// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostCorehrV1ContractsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建合同 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 新建合同 请求体
/// <para>通过本接口可以为员工创建一份新合同</para>
/// <para>接口ID：7017707615190876163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/contract/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fcontract%2fcreate</para>
/// </summary>
public record PostCorehrV1ContractsBodyDto
{
    /// <summary>
    /// <para>合同开始日期，格式："YYYY-MM-DD HH-mm-ss"</para>
    /// <para>必填：是</para>
    /// <para>示例值：2050-01-01 00:00:00</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string EffectiveTime { get; set; } = string.Empty;

    /// <summary>
    /// <para>实际结束日期,格式："YYYY-MM-DD HH-mm-ss"</para>
    /// <para>必填：否</para>
    /// <para>示例值：9999-12-31 23:59:59</para>
    /// </summary>
    [JsonPropertyName("expiration_time")]
    public string? ExpirationTime { get; set; }

    /// <summary>
    /// <para>雇佣 ID，详细信息可通过[【搜索员工信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employee/search)接口查询获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：6893013238632416776</para>
    /// </summary>
    [JsonPropertyName("employment_id")]
    public string EmploymentId { get; set; } = string.Empty;

    /// <summary>
    /// <para>合同类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
    /// <para>- object_api_name：contract</para>
    /// <para>- custom_api_name：contract_type</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonPropertyName("contract_type")]
    public Enum ContractType { get; set; } = new();

    /// <summary>
    /// <para>合同类型，枚举值可查询[获取字段详情](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口获取，按如下参数查询即可：</para>
    /// <para>- object_api_name：contract</para>
    /// <para>- custom_api_name：contract_type</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：labor_contract</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>合同签约公司, 引用的公司ID，详细信息可通过[【查询单个公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/get)接口查询获得</para>
    /// <para>必填：是</para>
    /// <para>示例值：6892686614112241165</para>
    /// </summary>
    [JsonPropertyName("first_party_company_id")]
    public string FirstPartyCompanyId { get; set; } = string.Empty;

    /// <summary>
    /// <para>合同签约人ID，详细信息可通过[【查询单个个人信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/person/get)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：151515151</para>
    /// </summary>
    [JsonPropertyName("person_id")]
    public string? PersonId { get; set; }

    /// <summary>
    /// <para>自定义字段，预留字段，暂时不支持</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public ObjectFieldData[]? CustomFields { get; set; }

    /// <summary>
    /// <para>自定义字段，预留字段，暂时不支持</para>
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
        /// <para>示例值：Sandy</para>
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>期限类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)合同期限类型（duration_type）枚举定义部分获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：fixed_term</para>
    /// </summary>
    [JsonPropertyName("duration_type")]
    public Enum? DurationType { get; set; }

    /// <summary>
    /// <para>合同结束日期，格式："YYYY-MM-DD"</para>
    /// <para>必填：否</para>
    /// <para>示例值：2006-01-02</para>
    /// </summary>
    [JsonPropertyName("contract_end_date")]
    public string? ContractEndDate { get; set; }

    /// <summary>
    /// <para>合同编号</para>
    /// <para>必填：否</para>
    /// <para>示例值：6919737965274990093</para>
    /// </summary>
    [JsonPropertyName("contract_number")]
    public string? ContractNumber { get; set; }

    /// <summary>
    /// <para>签订类型，枚举值可通过文档[【飞书人事枚举常量】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/feishu-people-enum-constant)签订类型（signing_type）枚举定义部分获得</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("signing_type")]
    public Enum? SigningType { get; set; }
}
