using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

// following code should be generated in the future
// for now, it's just a placeholder

namespace FeishuNetSdk.FeishuEvent.V2;

/// <summary>
/// 事件分发中心 - 分发事件
/// </summary>
public class DispatchCenter
{
    private readonly IServiceProvider        _provider;
    private readonly ILogger<DispatchCenter> _logger;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="provider"></param>
    /// <param name="logger"></param>
    public DispatchCenter(IServiceProvider provider, ILogger<DispatchCenter> logger)
    {
        _provider = provider;
        _logger   = logger;
    }

    public async System.Threading.Tasks.Task Dispatch(JsonElement json)
    {
        var eventType = json.GetProperty("header").GetProperty("event_type").GetString();

        var scope = _provider.CreateScope();

        _logger.LogInformation("Start processing event: {eventType}", eventType);

        if (Delegates.TryGetValue(eventType!, out var func))
        {
            await func.Invoke(json, scope.ServiceProvider);
        }
        else
        {
            _logger.LogError("Event type {eventType} not found.", eventType);
        }

        scope.Dispose();
    }

    /// <summary>
    /// 解密加密的事件, 如果不是加密的, 就什么都不做
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public JsonElement DecryptIfEncrypted(JsonElement json)
    {
        if (!json.TryGetProperty("encrypt", out var encryptElement)) return json;
        
        var encrypt = encryptElement.GetString()!;
        var message = new AESCipher("bxcfhExxxxxxxxxxxxxxxejx") // TODO make this configurable
           .DecryptString(encrypt);
        return JsonDocument.Parse(message).RootElement;

    }

    private static readonly Dictionary<string, Func<JsonElement, IServiceProvider, System.Threading.Tasks.Task>>
        Delegates = new()
        {
            ["contact.scope.updated_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.Scope.UpdatedV3>
                   .ParseJsonAndDispatch,
            ["contact.user.created_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.User.CreatedV3>
                   .ParseJsonAndDispatch,
            ["contact.user.deleted_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.User.DeletedV3>
                   .ParseJsonAndDispatch,
            ["contact.user.updated_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.User.UpdatedV3>
                   .ParseJsonAndDispatch,
            ["contact.custom_attr_event.updated_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.CustomAttrEvent.UpdatedV3>
                   .ParseJsonAndDispatch,
            ["contact.employee_type_enum.created_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.EmployeeTypeEnum.CreatedV3>
                   .ParseJsonAndDispatch,
            ["contact.employee_type_enum.actived_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.EmployeeTypeEnum.ActivedV3>
                   .ParseJsonAndDispatch,
            ["contact.employee_type_enum.deactivated_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.EmployeeTypeEnum.DeactivatedV3>
                   .ParseJsonAndDispatch,
            ["contact.employee_type_enum.deleted_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.EmployeeTypeEnum.DeletedV3>
                   .ParseJsonAndDispatch,
            ["contact.employee_type_enum.updated_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.EmployeeTypeEnum.UpdatedV3>
                   .ParseJsonAndDispatch,
            ["contact.department.created_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.Department.CreatedV3>
                   .ParseJsonAndDispatch,
            ["contact.department.deleted_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.Department.DeletedV3>
                   .ParseJsonAndDispatch,
            ["contact.department.updated_v3"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Contact.Department.UpdatedV3>
                   .ParseJsonAndDispatch,
            ["im.message.receive_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Message.ReceiveV1>
                   .ParseJsonAndDispatch,
            ["im.message.message_read_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Message.MessageReadV1>
                   .ParseJsonAndDispatch,
            ["im.message.recalled_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Message.RecalledV1>
                   .ParseJsonAndDispatch,
            ["im.message.reaction.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Message.Reaction.CreatedV1>
                   .ParseJsonAndDispatch,
            ["im.message.reaction.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Message.Reaction.DeletedV1>
                   .ParseJsonAndDispatch,
            ["im.chat.disbanded_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Chat.DisbandedV1>
                   .ParseJsonAndDispatch,
            ["im.chat.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Chat.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["im.chat.member.user.added_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Chat.Member.User.AddedV1>
                   .ParseJsonAndDispatch,
            ["im.chat.member.user.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Chat.Member.User.DeletedV1>
                   .ParseJsonAndDispatch,
            ["im.chat.member.user.withdrawn_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Chat.Member.User.WithdrawnV1>
                   .ParseJsonAndDispatch,
            ["im.chat.member.bot.added_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Chat.Member.Bot.AddedV1>
                   .ParseJsonAndDispatch,
            ["im.chat.member.bot.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Im.Chat.Member.Bot.DeletedV1>
                   .ParseJsonAndDispatch,
            ["drive.file.bitable_field_changed_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Drive.File.BitableFieldChangedV1>
                   .ParseJsonAndDispatch,
            // ["drive.file.read_v1"] =        // 	DispatchAs<FeishuNetSdk.FeishuEvent.V2.Drive.File.ReadV1>.Dispatch,
            // ["drive.file.edit_v1"] =        // 	DispatchAs<FeishuNetSdk.FeishuEvent.V2.Drive.File.EditV1>.Dispatch,
            // ["drive.file.permission_member_added_v1"] =        // 	DispatchAs<FeishuNetSdk.FeishuEvent.V2.Drive.File.PermissionMemberAddedV1>.Dispatch,
            // ["drive.file.permission_member_removed_v1"] =        // 	DispatchAs<FeishuNetSdk.FeishuEvent.V2.Drive.File.PermissionMemberRemovedV1>.Dispatch,
            // ["drive.file.trashed_v1"] =        // 	DispatchAs<FeishuNetSdk.FeishuEvent.V2.Drive.File.TrashedV1>.Dispatch,
            // ["drive.file.deleted_v1"] =        // 	DispatchAs<FeishuNetSdk.FeishuEvent.V2.Drive.File.DeletedV1>.Dispatch,
            ["calendar.calendar.changed_v4"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Calendar.Calendar.ChangedV4>
                   .ParseJsonAndDispatch,
            ["calendar.calendar.acl.created_v4"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Calendar.Calendar.Acl.CreatedV4>
                   .ParseJsonAndDispatch,
            ["calendar.calendar.acl.deleted_v4"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Calendar.Calendar.Acl.DeletedV4>
                   .ParseJsonAndDispatch,
            ["calendar.calendar.event.changed_v4"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Calendar.Calendar.Event.ChangedV4>
                   .ParseJsonAndDispatch,
            ["vc.meeting.all_meeting_started_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.AllMeetingStartedV1>
                   .ParseJsonAndDispatch,
            ["vc.meeting.all_meeting_ended_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.AllMeetingEndedV1>
                   .ParseJsonAndDispatch,
            ["vc.meeting.meeting_started_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.MeetingStartedV1>
                   .ParseJsonAndDispatch,
            ["vc.meeting.meeting_ended_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.MeetingEndedV1>
                   .ParseJsonAndDispatch,
            ["vc.meeting.join_meeting_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.JoinMeetingV1>
                   .ParseJsonAndDispatch,
            ["vc.meeting.leave_meeting_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.LeaveMeetingV1>
                   .ParseJsonAndDispatch,
            ["vc.meeting.recording_started_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.RecordingStartedV1>
                   .ParseJsonAndDispatch,
            ["vc.meeting.recording_ended_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.RecordingEndedV1>
                   .ParseJsonAndDispatch,
            ["vc.meeting.recording_ready_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.RecordingReadyV1>
                   .ParseJsonAndDispatch,
            ["vc.meeting.share_started_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.ShareStartedV1>
                   .ParseJsonAndDispatch,
            ["vc.meeting.share_ended_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Meeting.ShareEndedV1>
                   .ParseJsonAndDispatch,
            ["vc.room_level.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.RoomLevel.CreatedV1>
                   .ParseJsonAndDispatch,
            ["vc.room_level.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.RoomLevel.DeletedV1>
                   .ParseJsonAndDispatch,
            ["vc.room_level.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.RoomLevel.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["vc.room.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Room.CreatedV1>
                   .ParseJsonAndDispatch,
            ["vc.room.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Room.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["vc.room.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.Room.DeletedV1>
                   .ParseJsonAndDispatch,
            ["vc.reserve_config.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Vc.ReserveConfig.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["meeting_room.meeting_room.status_changed_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.MeetingRoom.MeetingRoom.StatusChangedV1>
                   .ParseJsonAndDispatch,
            ["meeting_room.meeting_room.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.MeetingRoom.MeetingRoom.CreatedV1>
                   .ParseJsonAndDispatch,
            ["meeting_room.meeting_room.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.MeetingRoom.MeetingRoom.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["meeting_room.meeting_room.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.MeetingRoom.MeetingRoom.DeletedV1>
                   .ParseJsonAndDispatch,
            // ["approval.approval.updated_v4"] =
            //  	DispatchAs<FeishuNetSdk.FeishuEvent.V2.Approval.Approval.UpdatedV4>.Dispatch,
            ["helpdesk.ticket.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Helpdesk.Ticket.CreatedV1>
                   .ParseJsonAndDispatch,
            ["helpdesk.ticket.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Helpdesk.Ticket.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["helpdesk.ticket_message.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Helpdesk.TicketMessage.CreatedV1>
                   .ParseJsonAndDispatch,
            ["helpdesk.notification.approve_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Helpdesk.Notification.ApproveV1>
                   .ParseJsonAndDispatch,
            ["task.task.update_tenant_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Task.Task.UpdateTenantV1>
                   .ParseJsonAndDispatch,
            ["task.task.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Task.Task.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["task.task.comment.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Task.Task.Comment.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["application.bot.menu_v6"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Application.Bot.MenuV6>
                   .ParseJsonAndDispatch,
            ["application.application.feedback.created_v6"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Application.Application.Feedback.CreatedV6>
                   .ParseJsonAndDispatch,
            ["application.application.feedback.updated_v6"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Application.Application.Feedback.UpdatedV6>
                   .ParseJsonAndDispatch,
            ["application.application.created_v6"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Application.Application.CreatedV6>
                   .ParseJsonAndDispatch,
            // ["application.application.visibility.added_v6"] =        // 	DispatchAs<FeishuNetSdk.FeishuEvent.V2.Application.        // 		Application.Visibility.AddedV6>.Dispatch,
            ["application.application.app_version.publish_apply_v6"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Application.Application.AppVersion.PublishApplyV6>
                   .ParseJsonAndDispatch,
            ["application.application.app_version.publish_revoke_v6"] =
                DispatchCenter<
                        FeishuNetSdk.FeishuEvent.V2.Application.Application.AppVersion.PublishRevokeV6>
                   .ParseJsonAndDispatch,
            ["application.application.app_version.audit_v6"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Application.Application.AppVersion.AuditV6>
                   .ParseJsonAndDispatch,
            ["hire.offer.status_changed_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Hire.Offer.StatusChangedV1>
                   .ParseJsonAndDispatch,
            ["hire.ehr_import_task_for_internship_offer.imported_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Hire.EhrImportTaskForInternshipOffer.ImportedV1>
                   .ParseJsonAndDispatch,
            // ["hire.ehr_import_task.imported_v1"] =        // 	DispatchAs<FeishuNetSdk.FeishuEvent.V2.Hire.EhrImportTask.ImportedV1>.Dispatch,
            // ["hire.application.stage_changed_v1"] =        // 	DispatchAs<FeishuNetSdk.FeishuEvent.V2.Hire.Application.StageChangedV1>.Dispatch,
            ["hire.application.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Hire.Application.DeletedV1>
                   .ParseJsonAndDispatch,
            ["hire.eco_account.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Hire.EcoAccount.CreatedV1>
                   .ParseJsonAndDispatch,
            ["hire.eco_background_check.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Hire.EcoBackgroundCheck.CreatedV1>
                   .ParseJsonAndDispatch,
            ["hire.eco_background_check.canceled_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Hire.EcoBackgroundCheck.CanceledV1>
                   .ParseJsonAndDispatch,
            ["hire.eco_exam.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Hire.EcoExam.CreatedV1>
                   .ParseJsonAndDispatch,
            ["hire.referral_account.assets_update_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Hire.ReferralAccount.AssetsUpdateV1>
                   .ParseJsonAndDispatch,
            ["acs.user.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Acs.User.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["acs.access_record.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Acs.AccessRecord.CreatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.employment.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Employment.CreatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.employment.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Employment.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.employment.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Employment.DeletedV1>
                   .ParseJsonAndDispatch,
            ["corehr.person.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Person.CreatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.person.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Person.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.person.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Person.DeletedV1>
                   .ParseJsonAndDispatch,
            ["corehr.department.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Department.CreatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.department.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Department.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.department.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Department.DeletedV1>
                   .ParseJsonAndDispatch,
            ["corehr.job.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Job.CreatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.job.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Job.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.job.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Job.DeletedV1>
                   .ParseJsonAndDispatch,
            ["corehr.pre_hire.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.PreHire.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.job_data.employed_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.JobData.EmployedV1>
                   .ParseJsonAndDispatch,
            ["corehr.contract.created_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Contract.CreatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.contract.deleted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Contract.DeletedV1>
                   .ParseJsonAndDispatch,
            ["corehr.contract.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Contract.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.employment.converted_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Employment.ConvertedV1>
                   .ParseJsonAndDispatch,
            ["corehr.job_data.changed_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.JobData.ChangedV1>
                   .ParseJsonAndDispatch,
            ["corehr.job_change.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.JobChange.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.offboarding.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Offboarding.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.employment.resigned_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Employment.ResignedV1>
                   .ParseJsonAndDispatch,
            ["corehr.org_role_authorization.updated_v1"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.OrgRoleAuthorization.UpdatedV1>
                   .ParseJsonAndDispatch,
            ["corehr.probation.updated_v2"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Probation.UpdatedV2>
                   .ParseJsonAndDispatch,
            ["corehr.process.updated_v2"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Process.UpdatedV2>
                   .ParseJsonAndDispatch,
            ["corehr.process.node.updated_v2"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Process.Node.UpdatedV2>
                   .ParseJsonAndDispatch,
            ["corehr.process.approver.updated_v2"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Process.Approver.UpdatedV2>
                   .ParseJsonAndDispatch,
            ["corehr.process.cc.updated_v2"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Corehr.Process.Cc.UpdatedV2>
                   .ParseJsonAndDispatch,
            ["elearning.course_registration.created_v2"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Elearning.CourseRegistration.CreatedV2>
                   .ParseJsonAndDispatch,
            ["elearning.course_registration.updated_v2"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Elearning.CourseRegistration.UpdatedV2>
                   .ParseJsonAndDispatch,
            ["elearning.course_registration.deleted_v2"] =
                DispatchCenter<FeishuNetSdk.FeishuEvent.V2.Elearning.CourseRegistration.DeletedV2>
                   .ParseJsonAndDispatch
        };
}

/// <summary>
/// 事件分发中心 - 解析 JSON 并分发事件
/// </summary>
/// <typeparam name="TEvent">事件类型</typeparam>
public partial class DispatchCenter<TEvent> // where TEvent : IEventContextV2
{
    /// <summary>
    /// 解析事件 并分发
    /// </summary>
    /// <param name="jsonElement"></param>
    /// <param name="provider"></param>
    public static async System.Threading.Tasks.Task ParseJsonAndDispatch(
        JsonElement jsonElement, IServiceProvider provider)
    {
        var @event = jsonElement.Deserialize<TEvent>()!;
        var logger = provider.GetRequiredService<ILogger<TEvent>>();
        if (Handlers.Count == 0)
        {
            var eventType = jsonElement.GetProperty("header").GetProperty("event_type").GetString();
            // throw new InvalidOperationException($"No handler registered for {eventType} event");
            logger.LogWarning("No handler registered for {eventType} event", eventType);
        }

        var tasks = Handlers.Select(handler => handler(@event, provider));
        await System.Threading.Tasks.Task.WhenAll(tasks);
    }
}

/// <summary>
/// 事件分发中心 - 注册事件处理委托
/// </summary>
/// <typeparam name="TEvent"></typeparam>
public static partial class DispatchCenter<TEvent>
{
    private static readonly List<Func<TEvent, IServiceProvider, System.Threading.Tasks.Task>> Handlers = new();

    /// <summary>
    /// 注册事件处理委托
    /// </summary>
    /// <param name="handler">处理事件的委托</param>
    public static void Register(Func<TEvent, System.Threading.Tasks.Task> handler) =>
        Handlers.Add((@event, _) => handler.Invoke(@event));

    /// <summary>
    /// 
    /// </summary>
    /// <param name="handler"></param>
    /// <typeparam name="T1"></typeparam>
    public static void Register<T1>(Func<TEvent, T1, System.Threading.Tasks.Task> handler)
        where T1 : notnull =>
        Handlers.Add((@event, provider) =>
        {
            var param1 = provider.GetRequiredService<T1>();
            return handler.Invoke(@event, param1);
        });

    /// <summary>
    /// 
    /// </summary>
    /// <param name="handler"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public static void Register<T1, T2>(Func<TEvent, T1, T2, System.Threading.Tasks.Task> handler)
        where T1 : notnull
        where T2 : notnull =>
        Handlers.Add((@event, provider) =>
        {
            var param1 = provider.GetRequiredService<T1>();
            var param2 = provider.GetRequiredService<T2>();
            return handler.Invoke(@event, param1, param2);
        });

    /// <summary>
    /// 
    /// </summary>
    /// <param name="handler"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    public static void Register<T1, T2, T3>(Func<TEvent, T1, T2, T3, System.Threading.Tasks.Task> handler)
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull =>
        Handlers.Add((@event, provider) =>
        {
            var param1 = provider.GetRequiredService<T1>();
            var param2 = provider.GetRequiredService<T2>();
            var param3 = provider.GetRequiredService<T3>();
            return handler.Invoke(@event, param1, param2, param3);
        });

    /// <summary>
    /// 
    /// </summary>
    /// <param name="handler"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    /// <typeparam name="T3"></typeparam>
    /// <typeparam name="T4"></typeparam>
    public static void Register<T1, T2, T3, T4>(Func<TEvent, T1, T2, T3, T4, System.Threading.Tasks.Task> handler)
        where T1 : notnull
        where T2 : notnull
        where T3 : notnull
        where T4 : notnull =>
        Handlers.Add((@event, provider) =>
        {
            var param1 = provider.GetRequiredService<T1>();
            var param2 = provider.GetRequiredService<T2>();
            var param3 = provider.GetRequiredService<T3>();
            var param4 = provider.GetRequiredService<T4>();
            return handler.Invoke(@event, param1, param2, param3, param4);
        });
}