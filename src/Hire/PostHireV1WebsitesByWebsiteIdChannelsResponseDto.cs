// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-07-11
//
// Last Modified By : yxr
// Last Modified On : 2024-07-11
// ************************************************************************
// <copyright file="PostHireV1WebsitesByWebsiteIdChannelsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新建招聘官网推广渠道 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Hire;
/// <summary>
/// 新建招聘官网推广渠道 响应体
/// <para>新建指定官网的推广渠道。每个官网可以新建多个推广渠道，每个推广渠道具有不同的推广链接和推广码。</para>
/// <para>接口ID：7097130725263474689</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/get-candidates/website/create-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fwebsite-channel%2fcreate</para>
/// </summary>
public record PostHireV1WebsitesByWebsiteIdChannelsResponseDto
{
    /// <summary>
    /// <para>推广渠道 ID</para>
    /// <para>必填：否</para>
    /// <para>示例值：7085989097067563300</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// <para>推广渠道名称</para>
    /// <para>必填：否</para>
    /// <para>示例值：官网微信渠道</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>推广渠道链接</para>
    /// <para>必填：否</para>
    /// <para>示例值：http://recrui-demo.jobs.xxx.cn/485083/?spread=A1KM6A5</para>
    /// </summary>
    [JsonPropertyName("link")]
    public string? Link { get; set; }

    /// <summary>
    /// <para>推广渠道推广码</para>
    /// <para>必填：否</para>
    /// <para>示例值：A1KM6A5</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}
