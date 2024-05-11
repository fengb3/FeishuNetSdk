namespace FeishuNetSdk.CompensationManagement;
/// <summary>
/// 批量查询员工薪资档案 请求体
/// <para>批量查询员工薪资档案</para>
/// <para>接口ID：7314129756769746948</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/compensation-v1/archive/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fquery</para>
/// </summary>
public record PostCompensationV1ArchivesQueryBodyDto
{
    /// <summary>
    /// <para>用户ID列表</para>
    /// <para>必填：是</para>
    /// <para>最大长度：100</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonPropertyName("user_id_list")]
    public string[] UserIdList { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>是否获取所有版本，参数为空时默认返回当前生效中的版本</para>
    /// <para>必填：否</para>
    /// <para>示例值：true</para>
    /// </summary>
    [JsonPropertyName("get_all_version")]
    public bool? GetAllVersion { get; set; }

    /// <summary>
    /// <para>生效开始时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2022-05-10</para>
    /// </summary>
    [JsonPropertyName("effective_start_date")]
    public string? EffectiveStartDate { get; set; }

    /// <summary>
    /// <para>生效结束时间</para>
    /// <para>必填：否</para>
    /// <para>示例值：2023-05-15</para>
    /// </summary>
    [JsonPropertyName("effective_end_date")]
    public string? EffectiveEndDate { get; set; }
}
