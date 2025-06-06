// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-04-18
//
// Last Modified By : yxr
// Last Modified On : 2025-04-18
// ************************************************************************
// <copyright file="PutBaseV2AppsByAppTokenRolesByRoleIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新自定义角色 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新自定义角色 响应体
/// <para>更新多维表格高级权限中自定义的角色。</para>
/// <para>## 前提条件</para>
/// <para>要调用自定义角色相关接口，你需确保多维表格已开启高级权限。你可通过[更新多维表格元数据](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app/update)接口开启高级权限。</para>
/// <para>接口ID：7473089245106323460</para>
/// <para>文档地址：https://open.feishu.cn/document/docs/bitable-v1/advanced-permission/app-role/update-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fadvanced-permission%2fbase-v2%2fapp-role%2fupdate</para>
/// </summary>
public record PutBaseV2AppsByAppTokenRolesByRoleIdResponseDto
{
    /// <summary>
    /// <para>自定义角色</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("role")]
    public PutBaseV2AppsByAppTokenRolesByRoleIdResponseDtoRole? Role { get; set; }

    /// <summary>
    /// <para>自定义角色</para>
    /// </summary>
    public record PutBaseV2AppsByAppTokenRolesByRoleIdResponseDtoRole
    {
        /// <summary>
        /// <para>自定义角色名称</para>
        /// <para>必填：是</para>
        /// <para>示例值：自定义权限1</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("role_name")]
        public string RoleName { get; set; } = string.Empty;

        /// <summary>
        /// <para>针对数据表的权限设置</para>
        /// <para>必填：是</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("table_roles")]
        public TableRole[] TableRoles { get; set; } = Array.Empty<TableRole>();

        /// <summary>
        /// <para>针对数据表的权限设置</para>
        /// </summary>
        public record TableRole
        {
            /// <summary>
            /// <para>数据表权限。</para>
            /// <para>**提示**：**协作者可编辑自己的记录** 和 **可编辑指定字段** 是 **可编辑记录** 的特殊情况，可通过指定 `rec_rule` 或 `field_perm` 参数实现相同的效果。</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>最大值：4</para>
            /// <para>最小值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：无权限</item>
            /// <item>1：可阅读</item>
            /// <item>2：可编辑</item>
            /// <item>4：可管理</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("table_perm")]
            public int TablePerm { get; set; }

            /// <summary>
            /// <para>数据表名</para>
            /// <para>必填：否</para>
            /// <para>示例值：数据表1</para>
            /// <para>最大长度：50</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("table_name")]
            public string? TableName { get; set; }

            /// <summary>
            /// <para>数据表 ID。详情参考[数据表 table](https://open.feishu.cn/document/ukTMukTMukTM/uUDN04SN0QjL1QDN/bitable-overview#8ff3bb0b)。</para>
            /// <para>必填：否</para>
            /// <para>示例值：tblKz5D60T4JlfcT</para>
            /// <para>最大长度：50</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("table_id")]
            public string? TableId { get; set; }

            /// <summary>
            /// <para>记录筛选条件，当 `table_perm` 为 1 或 2 时生效。用于指定可编辑或可阅读的记录。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("rec_rule")]
            public TableRoleRecRule? RecRule { get; set; }

            /// <summary>
            /// <para>记录筛选条件，当 `table_perm` 为 1 或 2 时生效。用于指定可编辑或可阅读的记录。</para>
            /// </summary>
            public record TableRoleRecRule
            {
                /// <summary>
                /// <para>记录筛选条件，用于指定可编辑或可阅读的记录。</para>
                /// <para>必填：否</para>
                /// <para>最大长度：10</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("conditions")]
                public RecRuleCondition[]? Conditions { get; set; }

                /// <summary>
                /// <para>记录筛选条件，用于指定可编辑或可阅读的记录。</para>
                /// </summary>
                public record RecRuleCondition
                {
                    /// <summary>
                    /// <para>条件字段的名称。记录筛选条件是“创建人包含访问者本人”时，此参数值为 ""。</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：单选</para>
                    /// </summary>
                    [JsonPropertyName("field_name")]
                    public string FieldName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>条件运算符</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：is</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>is：等于</item>
                    /// <item>isNot：不等于</item>
                    /// <item>contains：包含</item>
                    /// <item>doesNotContain：不包含</item>
                    /// <item>isEmpty：为空</item>
                    /// <item>isNotEmpty：不为空</item>
                    /// </list></para>
                    /// <para>默认值：is</para>
                    /// </summary>
                    [JsonPropertyName("operator")]
                    public string? Operator { get; set; }

                    /// <summary>
                    /// <para>条件的值，可以是单个值或多个值的数组。</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：["optbdVHf4q", "optrpd3eIJ"]</para>
                    /// <para>最大长度：50</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("values")]
                    public string[]? Values { get; set; }

                    /// <summary>
                    /// <para>字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：3</para>
                    /// <para>最大值：2000</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("field_type")]
                    public int? FieldType { get; set; }
                }

                /// <summary>
                /// <para>多个筛选条件的关系</para>
                /// <para>必填：否</para>
                /// <para>示例值：and</para>
                /// <para>可选值：<list type="bullet">
                /// <item>and：与</item>
                /// <item>or：或</item>
                /// </list></para>
                /// <para>默认值：and</para>
                /// </summary>
                [JsonPropertyName("conjunction")]
                public string? Conjunction { get; set; }

                /// <summary>
                /// <para>rec_rule 的记录对应的权限</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：仅可阅读</item>
                /// <item>2：可编辑</item>
                /// </list></para>
                /// <para>默认值：1</para>
                /// </summary>
                [JsonPropertyName("perm")]
                public int? Perm { get; set; }

                /// <summary>
                /// <para>其他记录权限</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>0：禁止查看</item>
                /// <item>1：仅可阅读</item>
                /// </list></para>
                /// <para>默认值：0</para>
                /// </summary>
                [JsonPropertyName("other_perm")]
                public int? OtherPerm { get; set; }
            }

            /// <summary>
            /// <para>记录筛选条件，在 `rec_rule.other_perm` 为 0 时生效。对于未命中 `rec_rule` 的记录，通过 `other_rec_rule` 指定可阅读记录范围；此时，既未命中 `rec_rule`、也未命中 `other_rec_rule` 的记录会被禁止阅读。</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonPropertyName("other_rec_rule")]
            public TableRoleOtherRecRule? OtherRecRule { get; set; }

            /// <summary>
            /// <para>记录筛选条件，在 `rec_rule.other_perm` 为 0 时生效。对于未命中 `rec_rule` 的记录，通过 `other_rec_rule` 指定可阅读记录范围；此时，既未命中 `rec_rule`、也未命中 `other_rec_rule` 的记录会被禁止阅读。</para>
            /// </summary>
            public record TableRoleOtherRecRule
            {
                /// <summary>
                /// <para>记录筛选条件</para>
                /// <para>必填：否</para>
                /// <para>最大长度：10</para>
                /// <para>最小长度：0</para>
                /// </summary>
                [JsonPropertyName("conditions")]
                public RecRuleCondition[]? Conditions { get; set; }

                /// <summary>
                /// <para>记录筛选条件</para>
                /// </summary>
                public record RecRuleCondition
                {
                    /// <summary>
                    /// <para>字段名</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：单选</para>
                    /// </summary>
                    [JsonPropertyName("field_name")]
                    public string FieldName { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>运算符</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：is</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>is：等于</item>
                    /// <item>isNot：不等于</item>
                    /// <item>contains：包含</item>
                    /// <item>doesNotContain：不包含</item>
                    /// <item>isEmpty：为空</item>
                    /// <item>isNotEmpty：不为空</item>
                    /// </list></para>
                    /// <para>默认值：is</para>
                    /// </summary>
                    [JsonPropertyName("operator")]
                    public string? Operator { get; set; }

                    /// <summary>
                    /// <para>单选或多选字段的选项 ID</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：["optbdVHf4q", "optrpd3eIJ"]</para>
                    /// <para>最大长度：50</para>
                    /// <para>最小长度：0</para>
                    /// </summary>
                    [JsonPropertyName("values")]
                    public string[]? Values { get; set; }

                    /// <summary>
                    /// <para>字段类型</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：3</para>
                    /// <para>最大值：2000</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonPropertyName("field_type")]
                    public int? FieldType { get; set; }
                }

                /// <summary>
                /// <para>多个筛选条件的关系</para>
                /// <para>必填：否</para>
                /// <para>示例值：and</para>
                /// <para>可选值：<list type="bullet">
                /// <item>and：与</item>
                /// <item>or：或</item>
                /// </list></para>
                /// <para>默认值：and</para>
                /// </summary>
                [JsonPropertyName("conjunction")]
                public string? Conjunction { get; set; }

                /// <summary>
                /// <para>规则筛选记录对应的权限</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：仅可阅读</item>
                /// <item>2：可编辑</item>
                /// </list></para>
                /// <para>默认值：1</para>
                /// </summary>
                [JsonPropertyName("perm")]
                public int? Perm { get; set; }
            }

            /// <summary>
            /// <para>字段权限，仅在 table_perm 为 2 时有意义，设置字段可编辑或可阅读权限</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"姓名": 1, "年龄": 2}</para>
            /// </summary>
            [JsonPropertyName("field_perm")]
            public object? FieldPerm { get; set; }

            /// <summary>
            /// <para>新增记录权限，仅在 table_perm 为 2 时有意义，用于设置记录是否可以新增</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>默认值：true</para>
            /// </summary>
            [JsonPropertyName("allow_add_record")]
            public bool? AllowAddRecord { get; set; }

            /// <summary>
            /// <para>删除记录权限，仅在 table_perm 为 2 时有意义，用于设置记录是否可以删除</para>
            /// <para>必填：否</para>
            /// <para>示例值：true</para>
            /// <para>默认值：true</para>
            /// </summary>
            [JsonPropertyName("allow_delete_record")]
            public bool? AllowDeleteRecord { get; set; }

            /// <summary>
            /// <para>视图权限</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>最大值：2</para>
            /// <para>最小值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：可阅读</item>
            /// <item>2：可编辑</item>
            /// </list></para>
            /// <para>默认值：2</para>
            /// </summary>
            [JsonPropertyName("view_perm")]
            public int? ViewPerm { get; set; }

            /// <summary>
            /// <para>可读的视图集合，仅在 view_perm 为 1 （视图为可阅读）时生效。</para>
            /// <para>- 未设置时，表示所有视图可读。</para>
            /// <para>- 设置后，表示设置的视图可读，未设置的视图无权限。</para>
            /// <para>该参数类型为 map，其中 key 是视图 ID，value 是视图对应的权限。value 枚举值有：</para>
            /// <para>- `0`：无权限</para>
            /// <para>- `1`：可阅读</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"vewEYknYcC": 0}</para>
            /// </summary>
            [JsonPropertyName("view_rules")]
            public object? ViewRules { get; set; }

            /// <summary>
            /// <para>字段点位的权限配置，仅可配置单多选字段、附件字段。点位的枚举值有：</para>
            /// <para>- `select_option_edit` : 选项配置点位，配置是否可增删改单、多选选项，未设置表示无权限。</para>
            /// <para>- `attachment_export`: 附件操作权限点位，配置是否可导出附件，未设置表示可导出。</para>
            /// <para>该参数类型为两层 map 结构，其中 key 是字段点位权限，value 是字段权限集合。字段权限集合也是一个 map 结构，其中 key 是字段名称，value 是字段点位权限：</para>
            /// <para>- `0`：无权限</para>
            /// <para>- `1`：有权限</para>
            /// <para>必填：否</para>
            /// <para>示例值：{"select_option_edit": {"单选1":0}}</para>
            /// </summary>
            [JsonPropertyName("field_action_rules")]
            public object? FieldActionRules { get; set; }
        }

        /// <summary>
        /// <para>自定义权限的id</para>
        /// <para>必填：否</para>
        /// <para>示例值：roljRpwIUt</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("role_id")]
        public string? RoleId { get; set; }

        /// <summary>
        /// <para>block权限</para>
        /// <para>必填：否</para>
        /// <para>最大长度：100</para>
        /// <para>最小长度：0</para>
        /// </summary>
        [JsonPropertyName("block_roles")]
        public BlockRole[]? BlockRoles { get; set; }

        /// <summary>
        /// <para>block权限</para>
        /// </summary>
        public record BlockRole
        {
            /// <summary>
            /// <para>Block ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：blknkqrP3RqUkcAW</para>
            /// <para>最大长度：100</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("block_id")]
            public string BlockId { get; set; } = string.Empty;

            /// <summary>
            /// <para>Block权限</para>
            /// <para>必填：是</para>
            /// <para>示例值：0</para>
            /// <para>可选值：<list type="bullet">
            /// <item>0：无权限</item>
            /// <item>1：可阅读</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("block_perm")]
            public int BlockPerm { get; set; }

            /// <summary>
            /// <para>Block类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：dashboard</para>
            /// <para>可选值：<list type="bullet">
            /// <item>dashboard：仪表盘</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("block_type")]
            public string? BlockType { get; set; }
        }

        /// <summary>
        /// <para>多维表格点位的权限。</para>
        /// <para>- 未设置时，表示自定义角色拥有所有点位权限。</para>
        /// <para>- 设置时，可设置以下两种权限：</para>
        /// <para>- `base_complex_edit` : 设置是否可以创建副本、下载、打印多维表格</para>
        /// <para>- `copy`: 设置是否可以复制多维表格内容</para>
        /// <para>该参数类型为 map，其中 key 是权限点位名称，value 是权限开关。value 枚举值有：</para>
        /// <para>- `0`：无权限</para>
        /// <para>- `1`：有权限</para>
        /// <para>必填：否</para>
        /// <para>示例值：{"duplicate": 1, "copy": 2}</para>
        /// </summary>
        [JsonPropertyName("base_rule")]
        public object? BaseRule { get; set; }
    }
}
