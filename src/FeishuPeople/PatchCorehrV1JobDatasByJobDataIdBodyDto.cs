// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-04-18
// ************************************************************************
// <copyright file="PatchCorehrV1JobDatasByJobDataIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新任职信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 更新任职信息 请求体
/// <para>默认为新增一条任职记录，包括职务、职级、序列、部门等信息。</para>
/// <para>接口ID：7072642400195723292</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/employee/job_data/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fjob_data%2fpatch</para>
/// </summary>
public record PatchCorehrV1JobDatasByJobDataIdBodyDto
{
    /// <summary>
    /// <para>任职记录版本 ID</para>
    /// <para>- ID 不为空时，将更新指定版本的任职记录内容</para>
    /// <para>- ID 为空时，将新增一个版本</para>
    /// <para>功能灰度中，若需要更新指定版本请联系[技术支持](https://applink.feishu.cn/TLJpeNdW)</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372697</para>
    /// </summary>
    [JsonPropertyName("version_id")]
    public string? VersionId { get; set; }

    /// <summary>
    /// <para>职务级别 ID，枚举值及详细信息可通过[【批量查询职级】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_level/list)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("job_level_id")]
    public string? JobLevelId { get; set; }

    /// <summary>
    /// <para>职等 ID，枚举值及详细信息可通过[【查询职等】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job_grade/query)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("job_grade_id")]
    public string? JobGradeId { get; set; }

    /// <summary>
    /// <para>人员类型 ID，枚举值及详细信息可通过[【批量查询人员类型】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/employee_type/list)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("employee_type_id")]
    public string? EmployeeTypeId { get; set; }

    /// <summary>
    /// <para>工时制度 ID，枚举值及详细信息可通过[【批量查询工时制度】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/working_hours_type/list)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("working_hours_type_id")]
    public string? WorkingHoursTypeId { get; set; }

    /// <summary>
    /// <para>工作地点 ID，枚举值及详细信息可通过[【批量查询地点】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/location/list)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("work_location_id")]
    public string? WorkLocationId { get; set; }

    /// <summary>
    /// <para>部门 ID，枚举值及详细信息可通过[【批量查询部门】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/department/batch_get)接口查询获得</para>
    /// <para>- 与 department_id_type 类型一致</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("department_id")]
    public string? DepartmentId { get; set; }

    /// <summary>
    /// <para>职务 ID，枚举值及详细信息可通过[【批量查询职务】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/job/list)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("job_id")]
    public string? JobId { get; set; }

    /// <summary>
    /// <para>试用期开始日期</para>
    /// <para>- strict_verify 为 true 时不支持该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：2018-03-16</para>
    /// </summary>
    [JsonPropertyName("probation_start_date")]
    public string? ProbationStartDate { get; set; }

    /// <summary>
    /// <para>试用期结束日期（实际结束日期）</para>
    /// <para>- strict_verify 为 true 时不支持该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：2019-05-24</para>
    /// </summary>
    [JsonPropertyName("probation_end_date")]
    public string? ProbationEndDate { get; set; }

    /// <summary>
    /// <para>是否为主任职</para>
    /// <para>- 该字段已废弃，默认为 true，不可更改</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("primary_job_data")]
    public bool? PrimaryJobData { get; set; }

    /// <summary>
    /// <para>生效时间</para>
    /// <para>- 不可为空字符，不传时默认值为当天</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-05-01 00:00:00</para>
    /// </summary>
    [JsonPropertyName("effective_time")]
    public string? EffectiveTime { get; set; }

    /// <summary>
    /// <para>失效时间</para>
    /// <para>- strict_verify 为 true 时不支持该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：2020-05-02 00:00:00</para>
    /// </summary>
    [JsonPropertyName("expiration_time")]
    public string? ExpirationTime { get; set; }

    /// <summary>
    /// <para>职务序列 ID，枚举值及详细信息可通过[【批量查询序列】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/job_family/list)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：1245678</para>
    /// </summary>
    [JsonPropertyName("job_family_id")]
    public string? JobFamilyId { get; set; }

    /// <summary>
    /// <para>业务类型（原：任职原因）</para>
    /// <para>- 枚举值[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)</para>
    /// <para>- object_api_name: job_data</para>
    /// <para>- custom_api_name: assignment_start_reason</para>
    /// <para>- 请注意，该枚举不允许填写为「onboarding、offboarding」，当上一个任职版本的值为「onboarding」时，该字段必填</para>
    /// <para>必填：否</para>
    /// <para>示例值：onboarding</para>
    /// </summary>
    [JsonPropertyName("assignment_start_reason")]
    public Enum? AssignmentStartReason { get; set; }

    /// <summary>
    /// <para>业务类型（原：任职原因）</para>
    /// <para>- 枚举值[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)</para>
    /// <para>- object_api_name: job_data</para>
    /// <para>- custom_api_name: assignment_start_reason</para>
    /// <para>- 请注意，该枚举不允许填写为「onboarding、offboarding」，当上一个任职版本的值为「onboarding」时，该字段必填</para>
    /// </summary>
    public record Enum
    {
        /// <summary>
        /// <para>枚举值</para>
        /// <para>必填：是</para>
        /// <para>示例值：job_status_change</para>
        /// </summary>
        [JsonPropertyName("enum_name")]
        public string EnumName { get; set; } = string.Empty;
    }

    /// <summary>
    /// <para>预计试用期结束日期</para>
    /// <para>- strict_verify 为 true 时不支持该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：2006-01-02</para>
    /// </summary>
    [JsonPropertyName("probation_expected_end_date")]
    public string? ProbationExpectedEndDate { get; set; }

    /// <summary>
    /// <para>直属上级的任职记录 ID，详细信息可通过[【批量查询员工任职信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employees-job_data/batch_get)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("direct_manager_id")]
    public string? DirectManagerId { get; set; }

    /// <summary>
    /// <para>虚线上级的任职记录 ID，详细信息可通过[【批量查询员工任职信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employees-job_data/batch_get)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：["6971723901730686501"]</para>
    /// </summary>
    [JsonPropertyName("dotted_line_manager_id_list")]
    public string[]? DottedLineManagerIdList { get; set; }

    /// <summary>
    /// <para>第二直属上级的任职记录 ID，详细信息可通过[【批量查询员工任职信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/employees-job_data/batch_get)接口查询获得</para>
    /// <para>- strict_verify 为 true 时不支持该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372679</para>
    /// </summary>
    [JsonPropertyName("second_direct_manager_id")]
    public string? SecondDirectManagerId { get; set; }

    /// <summary>
    /// <para>成本中心分摊信息</para>
    /// <para>- 当 version_id 有值时，不支持该字段</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("cost_center_rate")]
    public SupportCostCenterItem[]? CostCenterRates { get; set; }

    /// <summary>
    /// <para>成本中心分摊信息</para>
    /// <para>- 当 version_id 有值时，不支持该字段</para>
    /// </summary>
    public record SupportCostCenterItem
    {
        /// <summary>
        /// <para>支持的成本中心 ID，详细信息可通过[【搜索成本中心信息】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/cost_center/search)接口查询获得</para>
        /// <para>必填：否</para>
        /// <para>示例值：6950635856373745165</para>
        /// </summary>
        [JsonPropertyName("cost_center_id")]
        public string? CostCenterId { get; set; }

        /// <summary>
        /// <para>分摊比例</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("rate")]
        public int? Rate { get; set; }
    }

    /// <summary>
    /// <para>排班类型，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name = "job_data"</para>
    /// <para>- custom_api_name = "work_shift"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("work_shift")]
    public Enum? WorkShift { get; set; }

    /// <summary>
    /// <para>薪资类型，枚举值 api_name 可通过[【获取字段详情】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/custom_field/get_by_param)接口查询，查询参数如下：</para>
    /// <para>- object_api_name = "job_data"</para>
    /// <para>- custom_api_name = "compensation_type"</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("compensation_type")]
    public Enum? CompensationType { get; set; }

    /// <summary>
    /// <para>任职公司 ID，详细信息可通过[【批量查询公司】](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/company/list)接口查询获得</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372680</para>
    /// </summary>
    [JsonPropertyName("service_company")]
    public string? ServiceCompany { get; set; }

    /// <summary>
    /// <para>通道 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6890452208593372671</para>
    /// </summary>
    [JsonPropertyName("pathway_id")]
    public string? PathwayId { get; set; }
}
