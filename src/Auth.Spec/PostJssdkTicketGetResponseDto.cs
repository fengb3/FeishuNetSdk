// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostJssdkTicketGetResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>JSAPI 临时授权凭证 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Auth.Spec;
/// <summary>
/// 获取 JSAPI 临时授权凭证 响应体
/// <para>该接口用于返回调用 JSAPI 临时调用凭证，使用该凭证调用 JSAPI 时，请求不会被拦截。</para>
/// <para>接口ID：6911312738021720065</para>
/// <para>文档地址：https://open.feishu.cn/document/authentication-management/access-token/authorization</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuYTM5UjL2ETO14iNxkTN%2fh5_js_sdk%2fauthorization</para>
/// </summary>
public record PostJssdkTicketGetResponseDto
{
    /// <summary>
    /// <para>jsapi_ticket，调用 JSAPI 的临时票据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("ticket")]
    public string? Ticket { get; set; }

    /// <summary>
    /// <para>ticket 的有效时间（单位：秒）</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("expire_in")]
    public int? ExpireIn { get; set; }
}
