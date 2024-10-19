// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PutBitableV1AppsByAppTokenResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>更新多维表格元数据 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 更新多维表格元数据 响应体
/// <para>更新多维表格元数据，包括多维表格的名称、是否开启高级权限。</para>
/// <para>## 注意事项</para>
/// <para>- 在线文档和电子表格中嵌入的多维表格、知识库中的多维表格不支持开启高级权限。</para>
/// <para>- 此接口非原子操作，先修改多维表格名称，后开关高级权限，可能存在部分成功的情况。</para>
/// <para>接口ID：7073673019918811164</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fupdate</para>
/// </summary>
public record PutBitableV1AppsByAppTokenResponseDto
{
    /// <summary>
    /// <para>多维表格元数据</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("app")]
    public DisplayAppV2? App { get; set; }

    /// <summary>
    /// <para>多维表格元数据</para>
    /// </summary>
    public record DisplayAppV2
    {
        /// <summary>
        /// <para>多维表格的唯一标识 app_token</para>
        /// <para>必填：否</para>
        /// <para>示例值：S404b*****e9PQsYDWYcNryFn0g</para>
        /// </summary>
        [JsonPropertyName("app_token")]
        public string? AppToken { get; set; }

        /// <summary>
        /// <para>多维表格的名称</para>
        /// <para>必填：否</para>
        /// <para>示例值：app name</para>
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <para>多维表格是否已开启高级权限</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("is_advanced")]
        public bool? IsAdvanced { get; set; }

        /// <summary>
        /// <para>文档时区</para>
        /// <para>必填：否</para>
        /// <para>示例值：Asia/Beijing</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string? TimeZone { get; set; }
    }
}
