// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2024-06-24
//
// Last Modified By : yxr
// Last Modified On : 2024-06-24
// ************************************************************************
// <copyright file="GetImV1ChatsByChatIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>获取群信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Im;
/// <summary>
/// 获取群信息 响应体
/// <para>获取指定群的基本信息，包括群名称、群描述、群头像、群主 ID 以及群权限配置等。</para>
/// <para>## 前提条件</para>
/// <para>应用需要开启[机器人能力](https://open.feishu.cn/document/uAjLw4CM/ugTN1YjL4UTN24CO1UjN/trouble-shooting/how-to-enable-bot-ability)。</para>
/// <para>## 使用限制</para>
/// <para>- 调用接口的机器人或者用户需要在群组内，才可以获取完整信息，否则只返回群名称、群头像、成员数量以及群状态信息。</para>
/// <para>- 获取内部群信息时，调用接口的机器人或者用户需要与群组在同一租户下。</para>
/// <para>接口ID：6946222931479478273</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/group/chat/get-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fim-v1%2fchat%2fget</para>
/// </summary>
public record GetImV1ChatsByChatIdResponseDto
{
    /// <summary>
    /// <para>群头像 URL</para>
    /// <para>必填：否</para>
    /// <para>示例值：https://p3-lark-file.byteimg.com/img/lark-avatar-staging/default-avatar_44ae0ca3-e140-494b-956f-78091e348435~100x100.jpg</para>
    /// </summary>
    [JsonPropertyName("avatar")]
    public string? Avatar { get; set; }

    /// <summary>
    /// <para>群名称。没有设置群名称时，不会返回该参数。</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试群名称</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// <para>群描述</para>
    /// <para>必填：否</para>
    /// <para>示例值：测试群描述</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// <para>群国际化名称</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("i18n_names")]
    public GetImV1ChatsByChatIdResponseDtoI18nNames? I18nNames { get; set; }

    /// <summary>
    /// <para>群国际化名称</para>
    /// </summary>
    public record GetImV1ChatsByChatIdResponseDtoI18nNames
    {
        /// <summary>
        /// <para>中文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：群聊</para>
        /// </summary>
        [JsonPropertyName("zh_cn")]
        public string? ZhCn { get; set; }

        /// <summary>
        /// <para>英文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：group chat</para>
        /// </summary>
        [JsonPropertyName("en_us")]
        public string? EnUs { get; set; }

        /// <summary>
        /// <para>日文名</para>
        /// <para>必填：否</para>
        /// <para>示例值：グループチャット</para>
        /// </summary>
        [JsonPropertyName("ja_jp")]
        public string? JaJp { get; set; }
    }

    /// <summary>
    /// <para>谁可以添加群成员，群成员包括用户或机器人</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员</para>
    /// <para>- `all_members`：所有成员</para>
    /// <para>**注意**：单聊不返回该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// </summary>
    [JsonPropertyName("add_member_permission")]
    public string? AddMemberPermission { get; set; }

    /// <summary>
    /// <para>是否允许分享群</para>
    /// <para>**可选值有**：</para>
    /// <para>- `allowed`：允许</para>
    /// <para>- `not_allowed`：不允许</para>
    /// <para>**注意**：单聊不返回该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：allowed</para>
    /// </summary>
    [JsonPropertyName("share_card_permission")]
    public string? ShareCardPermission { get; set; }

    /// <summary>
    /// <para>谁可以 at 所有人</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员</para>
    /// <para>- `all_members`：所有成员</para>
    /// <para>**注意**：单聊不返回该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// </summary>
    [JsonPropertyName("at_all_permission")]
    public string? AtAllPermission { get; set; }

    /// <summary>
    /// <para>谁可以编辑群</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员</para>
    /// <para>- `all_members`：所有成员</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// </summary>
    [JsonPropertyName("edit_permission")]
    public string? EditPermission { get; set; }

    /// <summary>
    /// <para>群主的用户 ID 类型，与查询参数中的 user_id_type 相同。取值为 `open_id`、`user_id`、`union_id` 其中之一，不同 ID 的说明参见 [用户相关的 ID 概念](https://open.feishu.cn/document/home/user-identity-introduction/introduction)。</para>
    /// <para>**注意**：</para>
    /// <para>- 当群主是机器人时不返回该字段</para>
    /// <para>- 单聊不返回该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：user_id</para>
    /// </summary>
    [JsonPropertyName("owner_id_type")]
    public string? OwnerIdType { get; set; }

    /// <summary>
    /// <para>群主的用户 ID，ID 类型与查询参数中的 user_id_type 对应。</para>
    /// <para>**注意**：</para>
    /// <para>- 当群主是机器人时不返回该字段</para>
    /// <para>- 单聊不返回该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：4d7a3c6g</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; set; }

    /// <summary>
    /// <para>用户管理员 ID 列表，ID 类型与查询参数 user_id_type 一致。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("user_manager_id_list")]
    public string[]? UserManagerIdList { get; set; }

    /// <summary>
    /// <para>机器人管理员 ID 列表，ID 类型为应用的 App ID。</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("bot_manager_id_list")]
    public string[]? BotManagerIdList { get; set; }

    /// <summary>
    /// <para>群消息模式</para>
    /// <para>**可选值有**：</para>
    /// <para>- `chat`：会话消息</para>
    /// <para>- ` thread`：话题消息</para>
    /// <para>**注意**：仅普通对话群组返回该字段，话题群和单聊不返回值。</para>
    /// <para>必填：否</para>
    /// <para>示例值：chat</para>
    /// </summary>
    [JsonPropertyName("group_message_type")]
    public string? GroupMessageType { get; set; }

    /// <summary>
    /// <para>群模式</para>
    /// <para>**可选值有**：</para>
    /// <para>- `group`：群组</para>
    /// <para>- `topic`: 话题</para>
    /// <para>- `p2p`: 单聊</para>
    /// <para>必填：否</para>
    /// <para>示例值：group</para>
    /// </summary>
    [JsonPropertyName("chat_mode")]
    public string? ChatMode { get; set; }

    /// <summary>
    /// <para>群类型</para>
    /// <para>**可选值有**：</para>
    /// <para>- `private`：私有群</para>
    /// <para>- `public`：公开群</para>
    /// <para>**注意**：单聊不返回该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：private</para>
    /// </summary>
    [JsonPropertyName("chat_type")]
    public string? ChatType { get; set; }

    /// <summary>
    /// <para>群标签。如有多个，则按照下列顺序返回第一个标签。</para>
    /// <para>**可选值有**：</para>
    /// <para>- `inner`：内部群</para>
    /// <para>- `tenant`：公司群</para>
    /// <para>- `department`：部门群</para>
    /// <para>- `edu`：教育群</para>
    /// <para>- `meeting`：会议群</para>
    /// <para>- `customer_service`：客服群</para>
    /// <para>**注意**：单聊不返回该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：inner</para>
    /// </summary>
    [JsonPropertyName("chat_tag")]
    public string? ChatTag { get; set; }

    /// <summary>
    /// <para>入群提示消息的可见性</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员可见</para>
    /// <para>- `all_members`：所有成员可见</para>
    /// <para>- `not_anyone`：任何人均不可见</para>
    /// <para>**注意**：单聊不返回该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：only_owner</para>
    /// </summary>
    [JsonPropertyName("join_message_visibility")]
    public string? JoinMessageVisibility { get; set; }

    /// <summary>
    /// <para>出群提示消息的可见性</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员可见</para>
    /// <para>- `all_members`：所有成员可见</para>
    /// <para>- `not_anyone`：任何人均不可见</para>
    /// <para>**注意**：单聊不返回该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：only_owner</para>
    /// </summary>
    [JsonPropertyName("leave_message_visibility")]
    public string? LeaveMessageVisibility { get; set; }

    /// <summary>
    /// <para>加群是否需要审批</para>
    /// <para>**可选值有**：</para>
    /// <para>- `no_approval_required`：无需审批</para>
    /// <para>- `approval_required`：需要审批</para>
    /// <para>**注意**：单聊不返回该字段</para>
    /// <para>必填：否</para>
    /// <para>示例值：no_approval_required</para>
    /// </summary>
    [JsonPropertyName("membership_approval")]
    public string? MembershipApproval { get; set; }

    /// <summary>
    /// <para>群发言权限</para>
    /// <para>**可选值有**：</para>
    /// <para>- `only_owner`：仅群主和管理员</para>
    /// <para>- `all_members`：所有成员</para>
    /// <para>- `moderator_list`：指定群成员</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// </summary>
    [JsonPropertyName("moderation_permission")]
    public string? ModerationPermission { get; set; }

    /// <summary>
    /// <para>是否是外部群</para>
    /// <para>必填：否</para>
    /// <para>示例值：false</para>
    /// </summary>
    [JsonPropertyName("external")]
    public bool? External { get; set; }

    /// <summary>
    /// <para>租户 Key，为租户在飞书上的唯一标识，用来换取对应的tenant_access_token，也可以用作租户在应用中的唯一标识。</para>
    /// <para>必填：否</para>
    /// <para>示例值：736588c9260f175e</para>
    /// </summary>
    [JsonPropertyName("tenant_key")]
    public string? TenantKey { get; set; }

    /// <summary>
    /// <para>群内用户的数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：1</para>
    /// </summary>
    [JsonPropertyName("user_count")]
    public string? UserCount { get; set; }

    /// <summary>
    /// <para>群内机器人的数量</para>
    /// <para>必填：否</para>
    /// <para>示例值：3</para>
    /// </summary>
    [JsonPropertyName("bot_count")]
    public string? BotCount { get; set; }

    /// <summary>
    /// <para>保密模式设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonPropertyName("restricted_mode_setting")]
    public GetImV1ChatsByChatIdResponseDtoRestrictedModeSetting? RestrictedModeSetting { get; set; }

    /// <summary>
    /// <para>保密模式设置</para>
    /// </summary>
    public record GetImV1ChatsByChatIdResponseDtoRestrictedModeSetting
    {
        /// <summary>
        /// <para>保密模式是否开启</para>
        /// <para>必填：否</para>
        /// <para>示例值：false</para>
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }

        /// <summary>
        /// <para>允许截屏录屏</para>
        /// <para>必填：否</para>
        /// <para>示例值：all_members</para>
        /// <para>可选值：<list type="bullet">
        /// <item>all_members：所有成员允许截屏录屏</item>
        /// <item>not_anyone：所有成员禁止截屏录屏</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("screenshot_has_permission_setting")]
        public string? ScreenshotHasPermissionSetting { get; set; }

        /// <summary>
        /// <para>允许下载消息中图片、视频和文件</para>
        /// <para>必填：否</para>
        /// <para>示例值：all_members</para>
        /// <para>可选值：<list type="bullet">
        /// <item>all_members：所有成员允许下载资源</item>
        /// <item>not_anyone：所有成员禁止下载资源</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("download_has_permission_setting")]
        public string? DownloadHasPermissionSetting { get; set; }

        /// <summary>
        /// <para>允许复制和转发消息</para>
        /// <para>必填：否</para>
        /// <para>示例值：all_members</para>
        /// <para>可选值：<list type="bullet">
        /// <item>all_members：所有成员允许复制和转发消息</item>
        /// <item>not_anyone：所有成员禁止复制和转发消息</item>
        /// </list></para>
        /// </summary>
        [JsonPropertyName("message_has_permission_setting")]
        public string? MessageHasPermissionSetting { get; set; }
    }

    /// <summary>
    /// <para>谁可以加急</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>可选值：<list type="bullet">
    /// <item>only_owner：仅群主和管理员</item>
    /// <item>all_members：所有成员</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("urgent_setting")]
    public string? UrgentSetting { get; set; }

    /// <summary>
    /// <para>谁可以发起视频会议</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>可选值：<list type="bullet">
    /// <item>only_owner：仅群主和管理员</item>
    /// <item>all_members：所有成员</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("video_conference_setting")]
    public string? VideoConferenceSetting { get; set; }

    /// <summary>
    /// <para>隐藏群成员人数设置</para>
    /// <para>必填：否</para>
    /// <para>示例值：all_members</para>
    /// <para>可选值：<list type="bullet">
    /// <item>all_members：所有群成员可见</item>
    /// <item>only_owner：仅群主群管理员可见</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("hide_member_count_setting")]
    public string? HideMemberCountSetting { get; set; }

    /// <summary>
    /// <para>群状态</para>
    /// <para>必填：否</para>
    /// <para>示例值：normal</para>
    /// <para>可选值：<list type="bullet">
    /// <item>normal：正常</item>
    /// <item>dissolved：解散</item>
    /// <item>dissolved_save：解散并保留</item>
    /// </list></para>
    /// </summary>
    [JsonPropertyName("chat_status")]
    public string? ChatStatus { get; set; }
}
