namespace FeishuNetSdk.Ccm;
/// <summary>
/// 获取电子表格信息 响应体
/// <para>根据电子表格 token 获取电子表格的基础信息，包括电子表格的所有者、URL 链接等。</para>
/// <para>接口ID：7120425077330919452</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet%2fget</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenResponseDto
{
    /// <summary>
    /// <para>电子表格的基础信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("spreadsheet")]
    public GetSpreadsheet? Spreadsheet { get; set; }

    /// <summary>
    /// <para>电子表格的基础信息</para>
    /// </summary>
    public record GetSpreadsheet
    {
        /// <summary>
        /// <para>电子表格标题</para>
        /// <para>必填：否</para>
        /// <para>示例值：title</para>
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// <para>电子表格的所有者 ID。ID 类型由查询参数 user_id_type 决定。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ou_48d0958ee4b2ab3eaf0b5f6c968abcef</para>
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        /// <summary>
        /// <para>电子表格 token</para>
        /// <para>必填：否</para>
        /// <para>示例值：Iow7sNNEphp3WbtnbCscPqabcef</para>
        /// </summary>
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// <para>电子表格的 URL 链接</para>
        /// <para>必填：否</para>
        /// <para>示例值：https://example.feishu.cn/sheets/Iow7sNNEphp3WbtnbCscPqabcef</para>
        /// </summary>
        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
