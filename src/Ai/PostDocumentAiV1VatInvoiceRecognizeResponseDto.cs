// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-12-12
// ************************************************************************
// <copyright file="PostDocumentAiV1VatInvoiceRecognizeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>识别文件中的增值税发票 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Ai;
/// <summary>
/// 识别文件中的增值税发票 响应体
/// <para>增值税发票识别接口，支持JPG/JPEG/PNG/PDF/BMP/OFD六种文件类型的一次性的识别。</para>
/// <para>文件大小需要小于10M。</para>
/// <para>接口ID：7247054875321434114</para>
/// <para>文档地址：https://open.feishu.cn/document/ai/document_ai-v1/vat_invoice/recognize</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fai%2fdocument_ai-v1%2fvat_invoice%2frecognize</para>
/// </summary>
public record PostDocumentAiV1VatInvoiceRecognizeResponseDto
{
    /// <summary>
    /// <para>增值税发票信息</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("vat_invoices")]
    public VatInvoice[]? VatInvoices { get; set; }

    /// <summary>
    /// <para>增值税发票信息</para>
    /// </summary>
    public record VatInvoice
    {
        /// <summary>
        /// <para>识别出的实体列表</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonPropertyName("entities")]
        public VatEntity[]? Entities { get; set; }

        /// <summary>
        /// <para>识别出的实体列表</para>
        /// </summary>
        public record VatEntity
        {
            /// <summary>
            /// <para>识别的实体类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：buyer_name</para>
            /// <para>可选值：<list type="bullet">
            /// <item>invoice_name：发票抬头</item>
            /// <item>invoice_code：发票代码</item>
            /// <item>invoice_no：发票号码</item>
            /// <item>invoice_date：开票日期</item>
            /// <item>total_price：合计金额（不含税）</item>
            /// <item>total_tax：合计税额</item>
            /// <item>big_total_price_and_tax：合计总额（大写）</item>
            /// <item>check_code：校验码</item>
            /// <item>total_price_and_tax：合计总额</item>
            /// <item>buyer_name：购买方名称</item>
            /// <item>buyer_taxpayer_no：购买方纳税人识别号</item>
            /// <item>buyer_address_phone：购买方地址&amp;电话所有人</item>
            /// <item>buyer_account：购买方开户行&amp;账号</item>
            /// <item>seller_name：销售方名称</item>
            /// <item>seller_taxpayer_no：销售方纳税人识别号</item>
            /// <item>seller_address_phone：销售方地址&amp;电话</item>
            /// <item>seller_account：销售方开户行&amp;账号</item>
            /// <item>payee：收款人</item>
            /// <item>invoice_date：开票日期</item>
            /// <item>password_area：密码区</item>
            /// <item>remarks：备注</item>
            /// <item>reviewer：复核人</item>
            /// <item>drawer：开票人</item>
            /// <item>is_sealed：是否盖章</item>
            /// <item>seller_name_in_seal：印章内销售方名称</item>
            /// <item>seller_taxpayer_no_in_seal：印章内销售方纳税人识别号</item>
            /// <item>invoice_special_seal：印章名称</item>
            /// <item>machine_num：机器编号</item>
            /// </list></para>
            /// </summary>
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            /// <summary>
            /// <para>识别出字段的文本信息</para>
            /// <para>必填：否</para>
            /// <para>示例值：发呆公司</para>
            /// </summary>
            [JsonPropertyName("value")]
            public string? Value { get; set; }

            /// <summary>
            /// <para>识别出的票据详细信息</para>
            /// <para>必填：否</para>
            /// <para>最大长度：100000</para>
            /// <para>最小长度：0</para>
            /// </summary>
            [JsonPropertyName("items")]
            public KvEntity[][]? Items { get; set; }

            /// <summary>
            /// <para>识别出的票据详细信息</para>
            /// </summary>
            public record KvEntity
            {
                /// <summary>
                /// <para>识别的实体类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：entry_name</para>
                /// </summary>
                [JsonPropertyName("type")]
                public string? Type { get; set; }

                /// <summary>
                /// <para>识别出字段的文本信息</para>
                /// <para>必填：否</para>
                /// <para>示例值：餐饮服务</para>
                /// </summary>
                [JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }
    }
}
