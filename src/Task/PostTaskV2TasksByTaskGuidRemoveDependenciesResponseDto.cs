// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostTaskV2TasksByTaskGuidRemoveDependenciesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>移除依赖 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Task;
/// <summary>
/// 移除依赖 响应体
/// <para>从一个任务移除一个或者多个依赖。移除时只需要输入要移除的`task_guid`即可。</para>
/// <para>注意，如果要移除的依赖非当前任务的依赖，会被自动忽略。接口会返回成功。</para>
/// <para>接口ID：7277445986133442563</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/task/remove_dependencies</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2ftask%2fremove_dependencies</para>
/// </summary>
public record PostTaskV2TasksByTaskGuidRemoveDependenciesResponseDto
{
    /// <summary>
    /// <para>移除之后的任务GUID</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("dependencies")]
    public TaskDependency[]? Dependencies { get; set; }

    /// <summary>
    /// <para>移除之后的任务GUID</para>
    /// </summary>
    public record TaskDependency
    {
        /// <summary>
        /// <para>依赖类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：next</para>
        /// <para>可选值：<list type="bullet">
        /// <item>prev：前置依赖</item>
        /// <item>next：后置依赖</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// <para>依赖任务的GUID</para>
        /// <para>必填：是</para>
        /// <para>示例值：93b7bd05-35e6-4371-b3c9-6b7cbd7100c0</para>
        /// </summary>
        [JsonPropertyName("task_guid")]
        public string TaskGuid { get; set; } = string.Empty;
    }
}
