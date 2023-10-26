using Newtonsoft.Json;
namespace FeishuNetSdk.SecurityAndCompliance;
/// <summary>
/// 获取OpenAPI审计日志数据 请求体
/// <para>该接口用于获取OpenAPI审计日志数据</para>
/// <para>接口ID：7283168587871223810</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/security_and_compliance-v1/openapi_log/list_data</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fsecurity_and_compliance-v1%2fopenapi_log%2flist_data</para>
/// </summary>
public record PostSecurityAndComplianceV1OpenapiLogsListDataBodyDto
{
    /// <summary>
    /// <para>飞书开放平台定义的API，参考：[API列表](https://open.feishu.cn/document/server-docs/api-call-guide/server-api-list)</para>
    /// <para>必填：否</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("api_keys")]
    public string[]? ApiKeys { get; set; }

    /// <summary>
    /// <para>以秒为单位的起始时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1610613336</para>
    /// </summary>
    [JsonProperty("start_time")]
    public int? StartTime { get; set; }

    /// <summary>
    /// <para>以秒为单位的终止时间戳</para>
    /// <para>必填：否</para>
    /// <para>示例值：1610613336</para>
    /// </summary>
    [JsonProperty("end_time")]
    public int? EndTime { get; set; }

    /// <summary>
    /// <para>调用OpenAPI的应用唯一标识，可以前往 [开发者后台](https://open.feishu.cn/app) &gt; 应用详情页 &gt; 凭证与基础信息中获取 app_id</para>
    /// <para>必填：否</para>
    /// <para>示例值：cli_xxx</para>
    /// </summary>
    [JsonProperty("app_id")]
    public string? AppId { get; set; }

    /// <summary>
    /// <para>分页大小</para>
    /// <para>必填：否</para>
    /// <para>示例值：20</para>
    /// </summary>
    [JsonProperty("page_size")]
    public int? PageSize { get; set; }

    /// <summary>
    /// <para>分页标记，第一次请求不填，表示从头开始遍历；分页查询结果还有更多项时会同时返回新的 page_token，下次遍历可采用该 page_token 获取查询结果</para>
    /// <para>必填：否</para>
    /// <para>示例值：xxx</para>
    /// </summary>
    [JsonProperty("page_token")]
    public string? PageToken { get; set; }
}
