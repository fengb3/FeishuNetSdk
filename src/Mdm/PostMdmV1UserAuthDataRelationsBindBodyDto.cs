namespace FeishuNetSdk.Mdm;
/// <summary>
/// 用户数据维度绑定 请求体
/// <para>通过该接口，可为指定应用下的用户绑定一类数据维度，支持批量给多个用户同时增量授权。</para>
/// <para>接口ID：7120547953915510787</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/mdm-v1/user_auth_data_relation/bind</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fmdm-v1%2fuser_auth_data_relation%2fbind</para>
/// </summary>
public record PostMdmV1UserAuthDataRelationsBindBodyDto
{
    /// <summary>
    /// <para>数据类型编码</para>
    /// <para>必填：是</para>
    /// <para>示例值：gongsi</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("root_dimension_type")]
    public string RootDimensionType { get; set; } = string.Empty;

    /// <summary>
    /// <para>数据编码列表</para>
    /// <para>必填：是</para>
    /// <para>示例值：zijie</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("sub_dimension_types")]
    public string[] SubDimensionTypes { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>授权人的lark id</para>
    /// <para>必填：是</para>
    /// <para>示例值：on_21f2db9bdbafadeb16cd77b76060d41d</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("authorized_user_ids")]
    public string[] AuthorizedUserIds { get; set; } = Array.Empty<string>();

    /// <summary>
    /// <para>uams系统中应用id</para>
    /// <para>必填：是</para>
    /// <para>示例值：uams-tenant-test</para>
    /// <para>最大长度：200</para>
    /// </summary>
    [JsonPropertyName("uams_app_id")]
    public string UamsAppId { get; set; } = string.Empty;
}
