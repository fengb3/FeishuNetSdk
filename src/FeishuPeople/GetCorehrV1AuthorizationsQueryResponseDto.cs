// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetCorehrV1AuthorizationsQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>批量查询用户授权 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.FeishuPeople;
/// <summary>
/// 批量查询用户授权 响应体
/// <para>批量查询[飞书人事管理后台](https://people.feishu.cn/people/) -「设置」-「权限设置」中的用户授权信息。授权列表信息中包括员工ID、被授权的角色等信息。</para>
/// <para>接口ID：7372022997609906178</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/authorization/query-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2fauthorization%2fquery</para>
/// </summary>
public record GetCorehrV1AuthorizationsQueryResponseDto
{
    /// <summary>
    /// <para>查询的用户授权信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public RoleAuthorization[]? Items { get; set; }

    /// <summary>
    /// <para>查询的用户授权信息</para>
    /// </summary>
    public record RoleAuthorization
    {
        /// <summary>
        /// <para>员工 ID</para>
        /// <para>可以使用[搜索员工信息](https://open.larkoffice.com/document/server-docs/corehr-v1/employee/search)接口获取员工其他信息。</para>
        /// <para>必填：是</para>
        /// <para>示例值：6967639606963471902</para>
        /// </summary>
        [JsonPropertyName("employment_id")]
        public string EmploymentId { get; set; } = string.Empty;

        /// <summary>
        /// <para>授权列表</para>
        /// <para>必填：是</para>
        /// </summary>
        [JsonPropertyName("permission_detail_list")]
        public PermissionDetail[] PermissionDetailLists { get; set; } = Array.Empty<PermissionDetail>();

        /// <summary>
        /// <para>授权列表</para>
        /// </summary>
        public record PermissionDetail
        {
            /// <summary>
            /// <para>角色</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("role")]
            public SecurityGroup? Role { get; set; }

            /// <summary>
            /// <para>角色</para>
            /// </summary>
            public record SecurityGroup
            {
                /// <summary>
                /// <para>角色ID</para>
                /// <para>必填：是</para>
                /// <para>示例值：7034393015968122400</para>
                /// </summary>
                [JsonPropertyName("id")]
                public string Id { get; set; } = string.Empty;

                /// <summary>
                /// <para>角色code</para>
                /// <para>必填：是</para>
                /// <para>示例值：department_manager</para>
                /// </summary>
                [JsonPropertyName("code")]
                public string Code { get; set; } = string.Empty;

                /// <summary>
                /// <para>角色名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("name")]
                public SecurityGroupName? Name { get; set; }

                /// <summary>
                /// <para>角色名称</para>
                /// </summary>
                public record SecurityGroupName
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
                /// <para>角色描述</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("description")]
                public NameSuffix? Description { get; set; }

                /// <summary>
                /// <para>角色描述</para>
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
                /// <para>组织管理维度</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("org_truncation")]
                public OrgTruncation[]? OrgTruncations { get; set; }

                /// <summary>
                /// <para>组织管理维度</para>
                /// </summary>
                public record OrgTruncation
                {
                    /// <summary>
                    /// <para>组织管理维度名称</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：department</para>
                    /// </summary>
                    [JsonPropertyName("org_key")]
                    public string? OrgKey { get; set; }

                    /// <summary>
                    /// <para>下钻类型</para>
                    /// <para>- 0 = 对当前管理维度及下级管理维度均有权限</para>
                    /// <para>- 1 = 只对当前管理维度有权限，不包含其下级管理维度</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：0</para>
                    /// <para>最大值：100</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("type")]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>下钻深度</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：0</para>
                    /// <para>最大值：100</para>
                    /// <para>最小值：0</para>
                    /// </summary>
                    [JsonPropertyName("depth")]
                    public int? Depth { get; set; }
                }
            }

            /// <summary>
            /// <para>指定管理对象列表，如果该值为null，则使用设置数据权限(grantor_rule_list)</para>
            /// <para>json结构见响应体示例，其中：</para>
            /// <para>orgKey：组织key</para>
            /// <para>org_name：组织名称</para>
            /// <para>org_id_list：组织id</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("assigned_organization_list")]
            public AssignedOrganization[][]? AssignedOrganizationLists { get; set; }

            /// <summary>
            /// <para>指定管理对象列表，如果该值为null，则使用设置数据权限(grantor_rule_list)</para>
            /// <para>json结构见响应体示例，其中：</para>
            /// <para>orgKey：组织key</para>
            /// <para>org_name：组织名称</para>
            /// <para>org_id_list：组织id</para>
            /// </summary>
            public record AssignedOrganization
            {
                /// <summary>
                /// <para>管理对象key</para>
                /// <para>必填：是</para>
                /// <para>示例值：department</para>
                /// </summary>
                [JsonPropertyName("org_key")]
                public string OrgKey { get; set; } = string.Empty;

                /// <summary>
                /// <para>管理对象名称</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("org_name")]
                public Name? OrgName { get; set; }

                /// <summary>
                /// <para>管理对象名称</para>
                /// </summary>
                public record Name
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
                /// <para>管理对象id列表</para>
                /// <para>必填：是</para>
                /// </summary>
                [JsonPropertyName("org_id_list")]
                public string[] OrgIdList { get; set; } = Array.Empty<string>();
            }

            /// <summary>
            /// <para>设置数据权限，如果该值为null，则使用指定管理对象列表(assigned_organization_list)</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("grantor_rule_list")]
            public PermissionSecurityGroup[]? GrantorRuleLists { get; set; }

            /// <summary>
            /// <para>设置数据权限，如果该值为null，则使用指定管理对象列表(assigned_organization_list)</para>
            /// </summary>
            public record PermissionSecurityGroup
            {
                /// <summary>
                /// <para>管理维度</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("rule_dimension")]
                public PermissionSecurityGroupRuleDimension? RuleDimension { get; set; }

                /// <summary>
                /// <para>管理维度</para>
                /// </summary>
                public record PermissionSecurityGroupRuleDimension
                {
                    /// <summary>
                    /// <para>维度的key</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：员工</para>
                    /// </summary>
                    [JsonPropertyName("entity_key")]
                    public string? EntityKey { get; set; }

                    /// <summary>
                    /// <para>维度名称</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonPropertyName("entity_name")]
                    public Name? EntityName { get; set; }

                    /// <summary>
                    /// <para>维度名称</para>
                    /// </summary>
                    public record Name
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
                }

                /// <summary>
                /// <para>管理类型</para>
                /// <para>- 0：无数据权限</para>
                /// <para>- 1：全部数据权限</para>
                /// <para>- 2：被授权的用户自己</para>
                /// <para>- 3：按规则指定范围</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// </summary>
                [JsonPropertyName("rule_type")]
                public int? RuleType { get; set; }

                /// <summary>
                /// <para>规则</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonPropertyName("expression")]
                public FilterExpression? Expression { get; set; }

                /// <summary>
                /// <para>规则</para>
                /// </summary>
                public record FilterExpression
                {
                    /// <summary>
                    /// <para>规则</para>
                    /// <para>必填：否</para>
                    /// <para>最大长度：100</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("conditions")]
                    public FilterCondition[]? Conditions { get; set; }

                    /// <summary>
                    /// <para>规则</para>
                    /// </summary>
                    public record FilterCondition
                    {
                        /// <summary>
                        /// <para>左值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("left")]
                        public FilterRuleValue? Left { get; set; }

                        /// <summary>
                        /// <para>左值</para>
                        /// </summary>
                        public record FilterRuleValue
                        {
                            /// <summary>
                            /// <para>规则值类型（value的类型）</para>
                            /// <para>- 0 = 字符串</para>
                            /// <para>- 1 = 数字</para>
                            /// <para>- 2 = 字符串数组</para>
                            /// <para>- 3 = 数字数组</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// </summary>
                            [JsonPropertyName("type")]
                            public int? Type { get; set; }

                            /// <summary>
                            /// <para>规则值</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：a</para>
                            /// </summary>
                            [JsonPropertyName("value")]
                            public string? Value { get; set; }

                            /// <summary>
                            /// <para>下钻值</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：1</para>
                            /// </summary>
                            [JsonPropertyName("lookup_value")]
                            public string? LookupValue { get; set; }

                            /// <summary>
                            /// <para>下钻类型</para>
                            /// <para>必填：否</para>
                            /// <para>示例值：user</para>
                            /// </summary>
                            [JsonPropertyName("lookup_type")]
                            public string? LookupType { get; set; }
                        }

                        /// <summary>
                        /// <para>右值</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonPropertyName("right")]
                        public FilterRuleValue? Right { get; set; }

                        /// <summary>
                        /// <para>操作符</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>最大值：100</para>
                        /// <para>最小值：0</para>
                        /// </summary>
                        [JsonPropertyName("operator")]
                        public int? Operator { get; set; }

                        /// <summary>
                        /// <para>右值类型</para>
                        /// <para>- 1 = 指定值</para>
                        /// <para>- 2 = 引用</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>最大值：100</para>
                        /// <para>最小值：0</para>
                        /// </summary>
                        [JsonPropertyName("right_value_type")]
                        public int? RightValueType { get; set; }
                    }

                    /// <summary>
                    /// <para>表达式</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：1 and 2</para>
                    /// </summary>
                    [JsonPropertyName("expression")]
                    public string? Expression { get; set; }
                }
            }

            /// <summary>
            /// <para>更新时间(时间戳，单位：s)</para>
            /// <para>必填：否</para>
            /// <para>示例值：1720584039</para>
            /// </summary>
            [JsonPropertyName("update_time")]
            public string? UpdateTime { get; set; }
        }
    }

    /// <summary>
    /// <para>是否还有更多项</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("has_more")]
    public bool? HasMore { get; set; }

    /// <summary>
    /// <para>分页标记，当 has_more 为 true 时，会同时返回新的 page_token，否则不返回 page_token</para>
    /// <para>必填：否</para>
    /// <para>示例值：1234452132</para>
    /// </summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }
}
