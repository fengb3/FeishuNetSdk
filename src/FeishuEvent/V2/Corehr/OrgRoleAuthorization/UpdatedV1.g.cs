// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Corehr.OrgRoleAuthorization
{
    /// <summary>
    /// 【事件】组织角色授权变更<br/>
    /// 当组织上的角色授权发生变更时，触发该事件。例如在部门上修改了角色，并在 2030-01-01 年生效，则事件将在 2030-01-01 触发。注意：当前事件只返回在飞书人事中组织角色的变化，下游组织的影响，可以通过 「获取组织类角色授权列表」获取。<br/>
    /// </summary>
    /// <事件类型> corehr.org_role_authorization.updated_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/org_role_authorization/events/updated">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取用户授权数据 </li>
    /// <li> 获取核心人事信息 </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// 无
    /// </字段权限要求>
    public class UpdatedV1 : EventContext<UpdatedV1.EventData>
    {
        // EventData|role_id:string||management_scope_list:management_scope|management_dimension:string||obj_id:string||employment_id_list:string|
        public class EventData
        {
            	
            /// <summary>
            /// 角色id
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
            public string RoleId { get; init; }

            	
            /// <summary>
            /// 管理范围信息
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("management_scope_list")]
            public ManagementScope[] ManagementScopeList { get; init; }

            	
            /// <summary>
            /// 员工雇佣信息ID list
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("employment_id_list")]
            public string[] EmploymentIdList { get; init; }
        }

        // management_scope|management_dimension:string||obj_id:string|
        public class ManagementScope
        {
            	
            /// <summary>
            /// 管理维度
            /// 可选值有：
            /// department：部门work_location：工作地点company：公司social_security_location：社保城市
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("management_dimension")]
            public string ManagementDimension { get; init; }

            	
            /// <summary>
            /// 被授权部门/工作地点/公司/社保城市 ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("obj_id")]
            public string ObjId { get; init; }
        }
    }
}