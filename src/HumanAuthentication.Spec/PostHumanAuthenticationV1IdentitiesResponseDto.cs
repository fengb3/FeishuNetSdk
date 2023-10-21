using Newtonsoft.Json;
namespace FeishuNetSdk.HumanAuthentication.Spec;
/// <summary>
/// 录入身份信息 响应体
/// <para>该接口用于录入实名认证的身份信息，在唤起有源活体认证前，需要使用该接口进行实名认证。</para>
/// <para>接口ID：6940461543747305500</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/human_authentication-v1/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fhuman_authentication-v1%2fidentity%2fcreate</para>
/// </summary>
public record PostHumanAuthenticationV1IdentitiesResponseDto
{
    /// <summary>
    /// <para>用户绑定实名身份的uid</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("verify_uid")]
    public string? VerifyUid { get; set; }
}
