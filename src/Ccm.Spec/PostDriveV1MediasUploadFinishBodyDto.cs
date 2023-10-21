using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm.Spec;
/// <summary>
/// 分片上传素材（完成上传） 请求体
/// <para>触发完成上传。</para>
/// <para>接口ID：6979562676003880988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/media/multipart-upload-media/upload_finish</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2fmedia%2fupload_finish</para>
/// </summary>
public record PostDriveV1MediasUploadFinishBodyDto
{
    /// <summary>
    /// <para>分片上传事务ID</para>
    /// <para>**示例值**："7111211691345512356"</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("upload_id")]
    public string UploadId { get; set; } = string.Empty;

    /// <summary>
    /// <para>分片数量</para>
    /// <para>**示例值**：1</para>
    /// <para>必填：是</para>
    /// </summary>
    [JsonProperty("block_num")]
    public int BlockNum { get; set; }
}
