// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesQueryResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>查询浮动图片 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 查询浮动图片 响应体
/// <para>获取电子表格工作表内所有的浮动图片的参数信息。</para>
/// <para>接口ID：6976178542817263619</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/sheets-v3/spreadsheet-sheet-float_image/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fsheets-v3%2fspreadsheet-sheet-float_image%2fquery</para>
/// </summary>
public record GetSheetsV3SpreadsheetsBySpreadsheetTokenSheetsBySheetIdFloatImagesQueryResponseDto
{
    /// <summary>
    /// <para>工作表的所有浮动图片信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("items")]
    public FloatImage[]? Items { get; set; }

    /// <summary>
    /// <para>工作表的所有浮动图片信息</para>
    /// </summary>
    public record FloatImage
    {
        /// <summary>
        /// <para>浮动图片的唯一标识。用于对图片进行增删改查操作。</para>
        /// <para>必填：否</para>
        /// <para>示例值：ye06SS14ph</para>
        /// </summary>
        [JsonPropertyName("float_image_id")]
        public string? FloatImageId { get; set; }

        /// <summary>
        /// <para>浮动图片的 token，用于图片的上传和下载操作。你可通过该 token，调用[下载素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/download)接口下载图片。</para>
        /// <para>必填：否</para>
        /// <para>示例值：boxbcbQsaSqIXsxxxxx1HCPJFbh</para>
        /// </summary>
        [JsonPropertyName("float_image_token")]
        public string? FloatImageToken { get; set; }

        /// <summary>
        /// <para>浮动图片左上角所在单元格位置</para>
        /// <para>必填：否</para>
        /// <para>示例值：ahgsch!A1:A1</para>
        /// </summary>
        [JsonPropertyName("range")]
        public string? Range { get; set; }

        /// <summary>
        /// <para>浮动图片的宽度，单位为像素。</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("width")]
        public float? Width { get; set; }

        /// <summary>
        /// <para>浮动图片的高度，单位为像素。</para>
        /// <para>必填：否</para>
        /// <para>示例值：100</para>
        /// </summary>
        [JsonPropertyName("height")]
        public float? Height { get; set; }

        /// <summary>
        /// <para>浮动图片左上角距离所在单元格左上角的横向偏移，单位为像素。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("offset_x")]
        public float? OffsetX { get; set; }

        /// <summary>
        /// <para>浮动图片左上角距离所在单元格左上角的纵向偏移，单位为像素。</para>
        /// <para>必填：否</para>
        /// <para>示例值：0</para>
        /// </summary>
        [JsonPropertyName("offset_y")]
        public float? OffsetY { get; set; }
    }
}
