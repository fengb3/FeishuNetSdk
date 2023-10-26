using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 更新知识空间设置 响应体
/// <para>根据space_id更新知识空间公共设置</para>
/// <para>接口ID：7023947709203824644</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/wiki-v2/space-setting/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fwiki-v2%2fspace-setting%2fupdate</para>
/// </summary>
public record PutWikiV2SpacesBySpaceIdSettingResponseDto
{
    /// <summary>
    /// <para>知识空间设置</para>
    /// <para>必填：否</para>
    /// </summary>
    [JsonProperty("setting")]
    public PutWikiV2SpacesBySpaceIdSettingResponseDtoSetting? Setting { get; set; }

    /// <summary>
    /// <para>知识空间设置</para>
    /// </summary>
    public record PutWikiV2SpacesBySpaceIdSettingResponseDtoSetting
    {
        /// <summary>
        /// <para>谁可以创建空间的一级页面： "admin_and_member" = 管理员和成员 "admin" - 仅管理员</para>
        /// <para>必填：否</para>
        /// <para>示例值：admin/admin_and_member</para>
        /// </summary>
        [JsonProperty("create_setting")]
        public string? CreateSetting { get; set; }

        /// <summary>
        /// <para>可阅读用户可否创建副本/打印/导出/复制： "allow" - 允许 "not_allow" - 不允许</para>
        /// <para>必填：否</para>
        /// <para>示例值：allow/not_allow</para>
        /// </summary>
        [JsonProperty("security_setting")]
        public string? SecuritySetting { get; set; }

        /// <summary>
        /// <para>可阅读用户可否评论： "allow" - 允许 "not_allow" - 不允许</para>
        /// <para>必填：否</para>
        /// <para>示例值：allow/not_allow</para>
        /// </summary>
        [JsonProperty("comment_setting")]
        public string? CommentSetting { get; set; }
    }
}
