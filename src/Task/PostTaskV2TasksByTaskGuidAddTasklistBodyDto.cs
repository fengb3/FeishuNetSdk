using Newtonsoft.Json;
namespace FeishuNetSdk.Task;
/// <summary>
/// 任务加入清单 请求体
/// <para>将一个任务加入清单。返回任务的详细信息，包括任务所在的所有清单信息。</para>
/// <para>如果任务已经在该清单，接口将返回成功。</para>
/// <para>接口ID：7255580838154502172</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/task-v2/task/add_tasklist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fadd_tasklist</para>
/// </summary>
public record PostTaskV2TasksByTaskGuidAddTasklistBodyDto
{
    /// <summary>
    /// <para>要添加到的清单的全局唯一ID</para>
    /// <para>必填：是</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// <para>最大长度：100</para>
    /// </summary>
    [JsonProperty("tasklist_guid")]
    public string TasklistGuid { get; set; } = string.Empty;

    /// <summary>
    /// <para>要添加到清单的自定义分组全局唯一ID，如不填写表示添加到默认分组</para>
    /// <para>必填：否</para>
    /// <para>示例值：d300a75f-c56a-4be9-80d1-e47653028ceb</para>
    /// </summary>
    [JsonProperty("section_guid")]
    public string? SectionGuid { get; set; }
}