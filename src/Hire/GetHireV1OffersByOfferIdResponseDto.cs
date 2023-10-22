using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 获取 Offer 详情 响应体
/// <para>根据 Offer ID 获取 Offer 详细信息。</para>
/// <para>接口ID：7036562575123873793</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/offer/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2foffer%2fget</para>
/// </summary>
public record GetHireV1OffersByOfferIdResponseDto
{
    /// <summary>
    /// <para>Offer 详情</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("offer")]
    public GetHireV1OffersByOfferIdResponseDtoOffer? Offer { get; set; }

    /// <summary>
    /// <para>Offer 详情</para>
    /// </summary>
    public record GetHireV1OffersByOfferIdResponseDtoOffer
    {
        /// <summary>
        /// <para>Offer ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1231231231231231</para>
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// <para>投递 ID</para>
        /// <para>必填：否</para>
        /// <para>示例值：1231231232312312</para>
        /// </summary>
        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// <para>基础信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("basic_info")]
        public ApplicationOfferBasicInfo? BasicInfo { get; set; }

        /// <summary>
        /// <para>基础信息</para>
        /// </summary>
        public record ApplicationOfferBasicInfo
        {
            /// <summary>
            /// <para>Offer 类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：Social</item>
            /// <item>2：Campus</item>
            /// <item>3：Intern</item>
            /// <item>4：InternTransfer</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("offer_type")]
            public int? OfferType { get; set; }

            /// <summary>
            /// <para>备注</para>
            /// <para>必填：否</para>
            /// <para>示例值：10</para>
            /// </summary>
            [JsonProperty("remark")]
            public string? Remark { get; set; }

            /// <summary>
            /// <para>Offer 过期时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1653383498000</para>
            /// </summary>
            [JsonProperty("expire_time")]
            public int? ExpireTime { get; set; }

            /// <summary>
            /// <para>Offer 负责人 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_99be8e24ad1ad390b6cd3b8916940df1</para>
            /// </summary>
            [JsonProperty("owner_user_id")]
            public string? OwnerUserId { get; set; }

            /// <summary>
            /// <para>Offer 创建人 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_99be8e24ad1ad390b6cd3b8916940df1</para>
            /// </summary>
            [JsonProperty("creator_user_id")]
            public string? CreatorUserId { get; set; }

            /// <summary>
            /// <para>Offer 人员类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("employee_type")]
            public BaseBilingualWithId? EmployeeType { get; set; }

            /// <summary>
            /// <para>Offer 人员类型</para>
            /// </summary>
            public record BaseBilingualWithId
            {
                /// <summary>
                /// <para>ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：正式</para>
                /// </summary>
                [JsonProperty("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：Regular</para>
                /// </summary>
                [JsonProperty("en_name")]
                public string? EnName { get; set; }
            }

            /// <summary>
            /// <para>创建时间</para>
            /// <para>必填：否</para>
            /// <para>示例值：1628512038000</para>
            /// </summary>
            [JsonProperty("create_time")]
            public string? CreateTime { get; set; }

            /// <summary>
            /// <para>直属上级 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：ou_99be8e24ad1ad390b6cd3b8916940df1</para>
            /// </summary>
            [JsonProperty("leader_user_id")]
            public string? LeaderUserId { get; set; }

            /// <summary>
            /// <para>入职日期</para>
            /// <para>必填：否</para>
            /// <para>示例值：2021-05-20</para>
            /// </summary>
            [JsonProperty("onboard_date")]
            public string? OnboardDate { get; set; }

            /// <summary>
            /// <para>入职部门</para>
            /// <para>必填：否</para>
            /// <para>示例值：od-6b394871807047c7023ebfc1ff37cd3a</para>
            /// </summary>
            [JsonProperty("department_id")]
            public string? DepartmentId { get; set; }

            /// <summary>
            /// <para>试用期, 比如试用期6个月</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// </summary>
            [JsonProperty("probation_month")]
            public int? ProbationMonth { get; set; }

            /// <summary>
            /// <para>合同期(年)，推荐使用「contract_period」，如果Offer申请表中「合同期(年)」字段已停用，则不可使用该字段</para>
            /// <para>必填：否</para>
            /// <para>示例值：3</para>
            /// </summary>
            [JsonProperty("contract_year")]
            public int? ContractYear { get; set; }

            /// <summary>
            /// <para>合同期（年/月）</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("contract_period")]
            public ContractPeriodInfo? ContractPeriod { get; set; }

            /// <summary>
            /// <para>合同期（年/月）</para>
            /// </summary>
            public record ContractPeriodInfo
            {
                /// <summary>
                /// <para>合同周期类型</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：月</item>
                /// <item>2：年</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("period_type")]
                public int PeriodType { get; set; }

                /// <summary>
                /// <para>合同时长</para>
                /// <para>必填：是</para>
                /// <para>示例值：3</para>
                /// </summary>
                [JsonProperty("period")]
                public int Period { get; set; }
            }

            /// <summary>
            /// <para>雇员类型</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("recruitment_type")]
            public BaseBilingualWithId? RecruitmentType { get; set; }

            /// <summary>
            /// <para>序列</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("sequence")]
            public BaseBilingualWithId? Sequence { get; set; }

            /// <summary>
            /// <para>级别</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("level")]
            public BaseBilingualWithId? Level { get; set; }

            /// <summary>
            /// <para>入职地点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("onboard_address")]
            public BaseAddress? OnboardAddress { get; set; }

            /// <summary>
            /// <para>入职地点</para>
            /// </summary>
            public record BaseAddress
            {
                /// <summary>
                /// <para>ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：6932753007915206919</para>
                /// </summary>
                [JsonProperty("id")]
                public string? Id { get; set; }

                /// <summary>
                /// <para>中文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：名字</para>
                /// </summary>
                [JsonProperty("zh_name")]
                public string? ZhName { get; set; }

                /// <summary>
                /// <para>英文名称</para>
                /// <para>必填：否</para>
                /// <para>示例值：name</para>
                /// </summary>
                [JsonProperty("en_name")]
                public string? EnName { get; set; }

                /// <summary>
                /// <para>区域信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("district")]
                public BaseDistrict? District { get; set; }

                /// <summary>
                /// <para>区域信息</para>
                /// </summary>
                public record BaseDistrict
                {
                    /// <summary>
                    /// <para>中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：伦敦</para>
                    /// </summary>
                    [JsonProperty("zh_name")]
                    public string? ZhName { get; set; }

                    /// <summary>
                    /// <para>英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：London</para>
                    /// </summary>
                    [JsonProperty("en_name")]
                    public string? EnName { get; set; }

                    /// <summary>
                    /// <para>编码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：400700</para>
                    /// </summary>
                    [JsonProperty("code")]
                    public string? Code { get; set; }

                    /// <summary>
                    /// <para>地址类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// </summary>
                    [JsonProperty("location_type")]
                    public int? LocationType { get; set; }
                }

                /// <summary>
                /// <para>城市信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("city")]
                public BaseCity? City { get; set; }

                /// <summary>
                /// <para>城市信息</para>
                /// </summary>
                public record BaseCity
                {
                    /// <summary>
                    /// <para>中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：中文</para>
                    /// </summary>
                    [JsonProperty("zh_name")]
                    public string? ZhName { get; set; }

                    /// <summary>
                    /// <para>英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：eng</para>
                    /// </summary>
                    [JsonProperty("en_name")]
                    public string? EnName { get; set; }

                    /// <summary>
                    /// <para>编码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：400700</para>
                    /// </summary>
                    [JsonProperty("code")]
                    public string? Code { get; set; }

                    /// <summary>
                    /// <para>地址类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：COUNTRY</item>
                    /// <item>2：STATE</item>
                    /// <item>3：CITY</item>
                    /// <item>4：DISTRICT</item>
                    /// <item>5：ADDRESS</item>
                    /// </list></para>
                    /// </summary>
                    [JsonProperty("location_type")]
                    public int? LocationType { get; set; }
                }

                /// <summary>
                /// <para>省信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("state")]
                public BaseCity? State { get; set; }

                /// <summary>
                /// <para>国家信息</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("country")]
                public BaseCountry? Country { get; set; }

                /// <summary>
                /// <para>国家信息</para>
                /// </summary>
                public record BaseCountry
                {
                    /// <summary>
                    /// <para>中文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：中文</para>
                    /// </summary>
                    [JsonProperty("zh_name")]
                    public string? ZhName { get; set; }

                    /// <summary>
                    /// <para>英文名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：eng</para>
                    /// </summary>
                    [JsonProperty("en_name")]
                    public string? EnName { get; set; }

                    /// <summary>
                    /// <para>编码</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：400700</para>
                    /// </summary>
                    [JsonProperty("code")]
                    public string? Code { get; set; }

                    /// <summary>
                    /// <para>地址类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：COUNTRY</item>
                    /// <item>2：STATE</item>
                    /// <item>3：CITY</item>
                    /// <item>4：DISTRICT</item>
                    /// <item>5：ADDRESS</item>
                    /// </list></para>
                    /// </summary>
                    [JsonProperty("location_type")]
                    public int? LocationType { get; set; }
                }
            }

            /// <summary>
            /// <para>工作地点</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("work_address")]
            public BaseAddress? WorkAddress { get; set; }

            /// <summary>
            /// <para>自定义字段信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("customize_info_list")]
            public ApplicationOfferCustomValue[]? CustomizeInfoLists { get; set; }

            /// <summary>
            /// <para>自定义字段信息</para>
            /// </summary>
            public record ApplicationOfferCustomValue
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：key</para>
                /// </summary>
                [JsonProperty("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value</para>
                /// <para>必填：否</para>
                /// <para>示例值：value</para>
                /// </summary>
                [JsonProperty("customize_value")]
                public string? CustomizeValue { get; set; }
            }
        }

        /// <summary>
        /// <para>薪酬计划</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("salary_plan")]
        public ApplicationOfferSalaryPlan? SalaryPlan { get; set; }

        /// <summary>
        /// <para>薪酬计划</para>
        /// </summary>
        public record ApplicationOfferSalaryPlan
        {
            /// <summary>
            /// <para>币种</para>
            /// <para>必填：否</para>
            /// <para>示例值：CNY</para>
            /// </summary>
            [JsonProperty("currency")]
            public string? Currency { get; set; }

            /// <summary>
            /// <para>基本薪资，为JSON 格式，amount 代表基本薪资的金额，peroid 代表基本薪资的周期单位，如："{\"amount\":\"10000\",\"period\":2}"</para>
            /// <para>必填：否</para>
            /// <para>示例值：{\"amount\":\"10000\",\"period\":2}</para>
            /// </summary>
            [JsonProperty("basic_salary")]
            public string? BasicSalary { get; set; }

            /// <summary>
            /// <para>试用期百分比</para>
            /// <para>必填：否</para>
            /// <para>示例值：10%</para>
            /// </summary>
            [JsonProperty("probation_salary_percentage")]
            public string? ProbationSalaryPercentage { get; set; }

            /// <summary>
            /// <para>年终奖月数</para>
            /// <para>必填：否</para>
            /// <para>示例值：12</para>
            /// </summary>
            [JsonProperty("award_salary_multiple")]
            public string? AwardSalaryMultiple { get; set; }

            /// <summary>
            /// <para>期权股数</para>
            /// <para>必填：否</para>
            /// <para>示例值：11</para>
            /// </summary>
            [JsonProperty("option_shares")]
            public string? OptionShares { get; set; }

            /// <summary>
            /// <para>季度奖金额</para>
            /// <para>必填：否</para>
            /// <para>示例值：11111</para>
            /// </summary>
            [JsonProperty("quarterly_bonus")]
            public string? QuarterlyBonus { get; set; }

            /// <summary>
            /// <para>半年奖金额</para>
            /// <para>必填：否</para>
            /// <para>示例值：11111</para>
            /// </summary>
            [JsonProperty("half_year_bonus")]
            public string? HalfYearBonus { get; set; }

            /// <summary>
            /// <para>年度现金总额(数量，非公式)</para>
            /// <para>必填：否</para>
            /// <para>示例值：11111</para>
            /// </summary>
            [JsonProperty("total_annual_cash")]
            public string? TotalAnnualCash { get; set; }

            /// <summary>
            /// <para>自定义字段的 value 信息</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("customize_info_list")]
            public ApplicationOfferCustomValue[]? CustomizeInfoLists { get; set; }

            /// <summary>
            /// <para>自定义字段的 value 信息</para>
            /// </summary>
            public record ApplicationOfferCustomValue
            {
                /// <summary>
                /// <para>自定义字段 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：key</para>
                /// </summary>
                [JsonProperty("object_id")]
                public string? ObjectId { get; set; }

                /// <summary>
                /// <para>自定义字段 value</para>
                /// <para>必填：否</para>
                /// <para>示例值：value</para>
                /// </summary>
                [JsonProperty("customize_value")]
                public string? CustomizeValue { get; set; }
            }
        }

        /// <summary>
        /// <para>当前 Offer 使用的 Schema</para>
        /// <para>必填：否</para>
        /// <para>示例值：6963562624677398823</para>
        /// </summary>
        [JsonProperty("schema_id")]
        public string? SchemaId { get; set; }

        /// <summary>
        /// <para>Offer 状态</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：未申请</item>
        /// <item>2：审批中</item>
        /// <item>3：审批已撤回</item>
        /// <item>4：审批通过</item>
        /// <item>5：审批不通过</item>
        /// <item>6：Offer已发出</item>
        /// <item>7：候选人已接受</item>
        /// <item>8：候选人已拒绝</item>
        /// <item>9：Offer已失效</item>
        /// <item>10：未审批</item>
        /// <item>11：实习待入职（仅实习Offer具有）</item>
        /// <item>12：实习已入职（仅实习Offer具有）</item>
        /// <item>13：实习已离职（仅实习Offer具有）</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("offer_status")]
        public int? OfferStatus { get; set; }

        /// <summary>
        /// <para>Offer 类型</para>
        /// <para>必填：否</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：正式Offer</item>
        /// <item>2：实习Offer</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("offer_type")]
        public int? OfferType { get; set; }

        /// <summary>
        /// <para>职位信息</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("job_info")]
        public OfferJobInfo? JobInfo { get; set; }

        /// <summary>
        /// <para>职位信息</para>
        /// </summary>
        public record OfferJobInfo
        {
            /// <summary>
            /// <para>Offer 职位 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7080891505426925854</para>
            /// </summary>
            [JsonProperty("job_id")]
            public string? JobId { get; set; }

            /// <summary>
            /// <para>Offer 职位名称</para>
            /// <para>必填：否</para>
            /// <para>示例值：xx</para>
            /// </summary>
            [JsonProperty("job_name")]
            public string? JobName { get; set; }
        }
    }
}