// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-27
//
// Last Modified By : yxr
// Last Modified On : 2024-06-28
// ************************************************************************
// <copyright file="ImageFormControl.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>图片</summary>
// ************************************************************************
namespace FeishuNetSdk.Approval.Dtos
{
    /// <summary>
    /// 图片
    /// </summary>
    /// <param name="Value">控件值</param>
    public record ImageFormControl([property: JsonPropertyName("value")] string[] Value) : FormControlBase("image");

}
