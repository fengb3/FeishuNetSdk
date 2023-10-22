using Newtonsoft.Json;
namespace FeishuNetSdk.HumanAuthentication.Spec;
/// <summary>
/// 查询人脸认证结果 响应体
/// <para>无源人脸比对流程，开发者后台通过调用此接口请求飞书后台，对本次活体比对结果做校验。</para>
/// <para>无源人脸比对接入需申请白名单，接入前请联系飞书开放平台工作人员，邮箱：open-platform@bytedance.com。</para>
/// <para>接口ID：6940461543747256348</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/human_authentication-v1/query-recognition-result</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fhuman_authentication-v1%2fface%2fquery-recognition-result</para>
/// </summary>
public record GetFaceVerifyV1QueryAuthResultResponseDto
{
    /// <summary>
    /// <para>认证结果, 0: 认证中, 1: 认证成功, -1: 认证失败</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("auth_state")]
    public int? AuthState { get; set; }

    /// <summary>
    /// <para>认证时间，unix 时间戳</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("auth_timpstamp")]
    public int? AuthTimpstamp { get; set; }
}