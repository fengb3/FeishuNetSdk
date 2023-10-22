using Newtonsoft.Json;
namespace FeishuNetSdk.Base;
/// <summary>
/// 创建多维表格 请求体
/// <para>在指定目录下创建多维表格</para>
/// <para>接口ID：7047733935745007620</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fcreate</para>
/// </summary>
public record PostBitableV1AppsBodyDto
{
    /// <summary>
    /// <para>多维表格App名字</para>
    /// <para>必填：否</para>
    /// <para>示例值：一篇新的多维表格</para>
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>多维表格App归属文件夹。关于如何获取 folder_token，可参见[如何获取云文档资源相关 token](https://open.feishu.cn/document/server-docs/docs/faq#08bb5df6)</para>
    /// <para>必填：否</para>
    /// <para>示例值：fldbco*****CIMltVc</para>
    /// </summary>
    [JsonProperty("folder_token")]
    public string? FolderToken { get; set; }

    /// <summary>
    /// <para>文档时区，[详见](https://bytedance.feishu.cn/docx/YKRndTM7VoyDqpxqqeEcd67MnEf)</para>
    /// <para>必填：否</para>
    /// <para>示例值：Asia/Macau</para>
    /// </summary>
    [JsonProperty("time_zone")]
    public string? TimeZone { get; set; }
}