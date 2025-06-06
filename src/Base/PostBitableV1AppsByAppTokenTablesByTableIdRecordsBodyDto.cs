// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="PostBitableV1AppsByAppTokenTablesByTableIdRecordsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>新增记录 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Base;
/// <summary>
/// 新增记录 请求体
/// <para>在多维表格数据表中新增一条记录。</para>
/// <para>## 前提条件</para>
/// <para>调用此接口前，请确保当前调用身份（tenant_access_token 或 user_access_token）已有多维表格的编辑等文档权限，否则接口将返回 HTTP 403 或 400 状态码。了解更多，参考[如何为应用或用户开通文档权限](https://open.feishu.cn/document/ukTMukTMukTM/uczNzUjL3czM14yN3MTN#16c6475a)。</para>
/// <para>## 注意事项</para>
/// <para>从其它数据源同步的数据表，不支持对记录进行增加、删除、和修改操作。</para>
/// <para>接口ID：6952707657162522626</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-record/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-record%2fcreate</para>
/// </summary>
public record PostBitableV1AppsByAppTokenTablesByTableIdRecordsBodyDto
{
    /// <summary>
    /// <para>要新增的记录的数据。你需先指定数据表中的字段（即指定列），再传入正确格式的数据作为一条记录。</para>
    /// <para>**注意**：</para>
    /// <para>该接口支持的字段类型及其描述如下所示：</para>
    /// <para>- 文本： 填写字符串格式的值</para>
    /// <para>- 数字：填写数字格式的值</para>
    /// <para>- 单选：填写选项值，对于新的选项值，将会创建一个新的选项</para>
    /// <para>- 多选：填写多个选项值，对于新的选项值，将会创建一个新的选项。如果填写多个相同的新选项值，将会创建多个相同的选项</para>
    /// <para>- 日期：填写毫秒级时间戳</para>
    /// <para>- 复选框：填写 true 或 false</para>
    /// <para>- 条码</para>
    /// <para>- 人员：填写用户的[open_id](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-openid)、[union_id](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-union-id) 或 [user_id](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-obtain-user-id)，类型需要与 user_id_type 指定的类型一致</para>
    /// <para>- 电话号码：填写文本内容</para>
    /// <para>- 超链接：参考以下示例，text 为文本值，link 为 URL 链接</para>
    /// <para>- 附件：填写附件 token，需要先调用[上传素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_all)或[分片上传素材](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/media/upload_prepare)接口将附件上传至该多维表格中</para>
    /// <para>- 单向关联：填写被关联表的记录 ID</para>
    /// <para>- 双向关联：填写被关联表的记录 ID</para>
    /// <para>- 地理位置：填写经纬度坐标</para>
    /// <para>不同类型字段的数据结构请参考[多维表格记录数据结构](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/bitable-v1/app-table-record/bitable-record-data-structure-overview)。</para>
    /// <para>必填：是</para>
    /// <para>示例值：{ "人员": [ { "id": "ou_2910013f1e6456f16a0ce75ede9abcef" } ] }</para>
    /// </summary>
    [JsonPropertyName("fields")]
    public object Fields { get; set; } = new();
}
