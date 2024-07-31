// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Corehr.Probation
{
    /// <summary>
    /// 试用期状态变更<br/>
    /// 当试用期记录状态发生变更时，触发该事件。<br/>
    /// </summary>
    /// <事件类型> corehr.probation.updated_v2 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/corehr-v2/probation/events/updated">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取试用期信息 </li>
    /// <li> 读写试用期信息 </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// 无
    /// </字段权限要求>
    public class UpdatedV2 : EventContext<UpdatedV2.EventData>
    {
        // EventData|employment_id:string||probation_status:string||actual_probation_end_date:string|
        public class EventData
        {
            	
            /// <summary>
            /// 雇佣 ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("employment_id")]
            public string EmploymentId { get; init; }

            	
            /// <summary>
            /// 试用期状态
            /// 可选值有：
            /// pending：审批中rejected：已拒绝waiting：待发起转正approved：审批通过converted：已转正
            /// 展开
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("probation_status")]
            public string ProbationStatus { get; init; }

            	
            /// <summary>
            /// 试用期实际结束日期
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("actual_probation_end_date")]
            public string ActualProbationEndDate { get; init; }
        }
    }
}