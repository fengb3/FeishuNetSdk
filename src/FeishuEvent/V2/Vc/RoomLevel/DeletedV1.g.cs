// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace FeishuNetSdk.FeishuEvent.V2.Vc.RoomLevel
{
    /// <summary>
    /// 删除会议室层级<br/>
    /// 当删除会议室成层级时，会触发该事件。<br/>
    /// </summary>
    /// <事件类型> vc.room_level.deleted_v1 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/vc-v1/room_level/events/deleted">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 更新视频会议室信息 </li>
    /// <li> 获取视频会议室信息 </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// 无
    /// </字段权限要求>
    public class DeletedV1 : EventContext<DeletedV1.EventData>
    {
        // EventData|room_level_id:string||delete_child:boolean|
        public class EventData
        {
            	
            /// <summary>
            /// 层级ID
            /// 数据校验规则：
            /// 长度范围：1 ～ 100 字符
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("room_level_id")]
            public string RoomLevelId { get; init; }

            	
            /// <summary>
            /// 是否删除所有子层级
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("delete_child")]
            public bool DeleteChild { get; init; }
        }
    }
}