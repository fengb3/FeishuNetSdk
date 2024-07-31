// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Corehr.Department
{
    /// <summary>
    /// 【事件】创建部门<br/>
    /// 飞书人事中「部门被创建」时将触发此事件。注意：1. 触发时间为部门实际生效时间，如在 2022-01-01 创建部门，部门生效时间设置为 2022-05-01，事件将在 2022-05-01 进行推送。2. 现在创建部门也会同时触发「部门更新」事件<br/>
    /// </summary>
    /// <事件类型> corehr.department.created_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/department/events/created">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取核心人事信息 </li>
    /// <li> 获取部门信息 </li>
    /// <li> 读写部门信息 </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// 无
    /// </字段权限要求>
    public class CreatedV1 : EventContext<CreatedV1.EventData>
    {
        // EventData|department_id:string|
        public class EventData
        {
            	
            /// <summary>
            /// 新建部门的 ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("department_id")]
            public string DepartmentId { get; init; }
        }
    }
}