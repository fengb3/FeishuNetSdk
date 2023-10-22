using Newtonsoft.Json;
namespace FeishuNetSdk.Ai.Spec;
/// <summary>
/// 识别图片中的文字 响应体
/// <para>可识别图片中的文字，按图片中的区域划分，分段返回文本列表。</para>
/// <para>接口ID：6949829039872000001</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/ai/optical_char_recognition-v1/basic_recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2foptical_char_recognition-v1%2fimage%2fbasic_recognize</para>
/// </summary>
public record PostOpticalCharRecognitionV1ImageBasicRecognizeResponseDto
{
    /// <summary>
    /// <para>按区域识别，返回文本列表</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("text_list")]
    public string[]? TextList { get; set; }
}