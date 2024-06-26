namespace FeishuNetSdk.Corehr;
/// <summary>
/// 查询支行信息 请求体
/// <para>根据银行 ID、支行 ID 、支行名称查询银行信息</para>
/// <para>接口ID：7301516605753212931</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/basic_info-bank_branch/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fbasic_info-bank_branch%2fsearch</para>
/// </summary>
public record PostCorehrV2BasicInfoBankBranchsSearchBodyDto
{
    /// <summary>
    /// <para>银行 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("bank_id_list")]
    public string[]? BankIdList { get; set; }

    /// <summary>
    /// <para>支行 ID 列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("bank_branch_id_list")]
    public string[]? BankBranchIdList { get; set; }

    /// <summary>
    /// <para>支行名称列表，支持对支行名称精确搜索</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonPropertyName("bank_branch_name_list")]
    public string[]? BankBranchNameList { get; set; }

    /// <summary>
    /// <para>状态列表</para>
    /// <para>必填：否</para>
    /// <para>最大长度：2</para>
    /// <para>默认值：[1]</para>
    /// </summary>
    [JsonPropertyName("status_list")]
    public int[]? StatusList { get; set; }

    /// <summary>
    /// <para>最早更新时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01 00:00:00</para>
    /// </summary>
    [JsonPropertyName("update_start_time")]
    public string? UpdateStartTime { get; set; }

    /// <summary>
    /// <para>最晚更新时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2024-01-01 00:00:00</para>
    /// </summary>
    [JsonPropertyName("update_end_time")]
    public string? UpdateEndTime { get; set; }
}
