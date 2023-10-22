using Newtonsoft.Json;
namespace FeishuNetSdk.Hire;
/// <summary>
/// 创建投递 响应体
/// <para>根据人才 ID 和职位 ID 创建投递。</para>
/// <para>接口ID：6964286393804816412</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/application/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fapplication%2fcreate</para>
/// </summary>
public record PostHireV1ApplicationsResponseDto
{
    /// <summary>
    /// <para>投递ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：6920175883425581324</para>
    /// </summary>
    [JsonProperty("id")]
    public string? Id { get; set; }
}