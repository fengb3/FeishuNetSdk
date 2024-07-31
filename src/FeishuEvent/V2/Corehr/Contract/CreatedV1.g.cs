// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Corehr.Contract
{
    /// <summary>
    /// 合同创建<br/>
    /// 合同创建<br/>
    /// </summary>
    /// <事件类型> corehr.contract.created_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/corehr-v1/contract/events/created">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 查看合同信息 </li>
    /// <li> 获取核心人事信息 </li>
    /// <li> 创建、更新、删除合同信息 (仅自建应用) </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// 无
    /// </字段权限要求>
    public class CreatedV1 : EventContext<CreatedV1.EventData>
    {
        // EventData|contract_id:string|
        public class EventData
        {
            	
            /// <summary>
            /// ID
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("contract_id")]
            public string ContractId { get; init; }
        }
    }
}