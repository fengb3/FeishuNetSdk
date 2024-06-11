﻿namespace FeishuNetSdk
{
    /// <summary>
    /// DTO扩展方法
    /// </summary>
    public static class DtoExtensions
    {
        /// <summary>
        /// 设置控件的方法
        /// </summary>
        /// <param name="Dto">创建审批实例 请求体</param>
        /// <param name="FormControls">
        /// <para>支持的控件明细参见：FeishuNetSdk.Approval.Dto 命名空间下：</para>
        /// <list type="bullet">
        /// <item>InputFormControl</item>
        /// <item>TextareaFormControl</item>
        /// <item>NumberFormControl</item>
        /// <item>AmountFormControl</item>
        /// <item>DateFormControl</item>
        /// <item>DateIntervalFormControl</item>
        /// <item>FormulaFormControl</item>
        /// <item>AttachmentFormControl</item>
        /// <item>ImageFormControl</item>
        /// <item>ContactFormControl</item>
        /// <item>ConnectFormControl</item>
        /// <item>RadioFormControl</item>
        /// <item>CheckboxFormControl</item>
        /// <item>FieldListFormControl</item>
        /// <item>DepartmentFormControl</item>
        /// <item>TelephoneFormControl</item>
        /// <item>ShiftGroupFormControl</item>
        /// </list>
        /// </param>
        public static void SetFormControls(
            this Approval.PostApprovalV4InstancesBodyDto Dto,
            object[] FormControls)
                => Dto.Form = System.Text.Json.JsonSerializer.Serialize(FormControls);

        /// <summary>
        /// 获取序列化的控件信息
        /// </summary>
        /// <param name="Dto">查看指定审批定义 响应体</param>
        /// <returns>序列化的控件数组</returns>
        public static Approval.Dtos.FromControl[]? GetFormControls(
            this Approval.GetApprovalV4ApprovalsByApprovalCodeResponseDto? Dto)
                => Dto is null ? null
                    : System.Text.Json.JsonSerializer.Deserialize<Approval.Dtos.FromControl[]>(Dto.Form);

        /// <summary>
        /// 设置消息卡片内容
        /// </summary>
        /// <param name="Dto">延时更新消息卡片 请求体</param>
        /// <param name="CardObject">消息卡片的描述内容</param>
        public static void SetCardObject(
            this Im.Spec.PostInteractiveV1CardUpdateBodyDto Dto,
            Im.Dtos.IHasOpenIds CardObject)
                => Dto.Card = CardObject;

        /// <summary>
        /// 设置消息内容
        /// </summary>
        /// <param name="Dto">发送消息 请求体</param>
        /// <param name="Content">消息对象
        /// <list type="bullet">
        /// <item>TextContent</item>
        /// <item>PostContent</item>
        /// <item>ImageContent</item>
        /// <item>FileContent</item>
        /// <item>AudioContent</item>
        /// <item>MediaContent</item>
        /// <item>StickerContent</item>
        /// <item>InteractiveElementContent</item>
        /// <item>InteractiveTemplateContent</item>
        /// <item>ShareChatContent</item>
        /// <item>ShareUserContent</item>
        /// </list>
        /// </param>
        public static void SetContent(
            this Im.PostImV1MessagesBodyDto Dto,
            Im.Dtos.IHasMessageType Content)
        {
            Dto.MsgType = Content.MessageType;
            Dto.Content = System.Text.Json.JsonSerializer.Serialize(Content, Content.GetType());
        }
    }
}
