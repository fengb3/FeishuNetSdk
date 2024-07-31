// <auto-generated />


using FeishuNetSdk.FeishuEvent.V2;

namespace  FeishuNetSdk.FeishuEvent.V2.Contact.EmployeeTypeEnum
{
    /// <summary>
    /// 修改人员类型名称<br/>
    /// 修改人员类型名称会发出对应事件。<br/>
    /// </summary>
    /// <事件类型> contact.employee_type_enum.updated_v3 </事件类型>
    /// <事件版本> V2.0 </事件版本>
    /// <自建应用> 支持 </自建应用>
    /// <商店应用> 支持 </商店应用>
    /// <文档链接> <a href="https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/contact-v3/employee_type_enum/events/updated">在open.feishu.cn中查看</a> </文档链接>
    /// <权限要求>
    /// <ul>
    /// <li> 获取通讯录基本信息 </li>
    /// <li> 以应用身份读取通讯录 </li>
    /// <li> 以应用身份访问通讯录 (历史版本) </li>
    /// </ul>
    /// </权限要求>
    /// <字段权限要求>
    /// 无
    /// </字段权限要求>
    public class UpdatedV3 : EventContext<UpdatedV3.EventData>
    {
        // EventData|old_enum:employee_type_enum|enum_id:string||enum_value:string||content:string||enum_type:int||enum_status:int||i18n_content:i18n_content|locale:string||value:string||new_enum:employee_type_enum|enum_id:string||enum_value:string||content:string||enum_type:int||enum_status:int||i18n_content:i18n_content|locale:string||value:string|
        public class EventData
        {
            	
            /// <summary>
            /// 旧枚举类型
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("old_enum")]
            public EmployeeTypeEnum OldEnum { get; init; }

            	
            /// <summary>
            /// 新枚举类型
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("new_enum")]
            public EmployeeTypeEnum NewEnum { get; init; }
        }

        // employee_type_enum|enum_id:string||enum_value:string||content:string||enum_type:int||enum_status:int||i18n_content:i18n_content|locale:string||value:string|
        public class EmployeeTypeEnum
        {
            	
            /// <summary>
            /// 枚举值id
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("enum_id")]
            public string EnumId { get; init; }

            	
            /// <summary>
            /// 枚举的编号值，创建新的人员类型后，系统生成对应编号。对应创建用户接口中用户信息的employee_type字段值
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("enum_value")]
            public string EnumValue { get; init; }

            	
            /// <summary>
            /// 枚举内容
            /// 数据校验规则：
            /// 长度范围：1 ～ 100 字符
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("content")]
            public string Content { get; init; }

            	
            /// <summary>
            /// 类型
            /// 可选值有：
            /// 1：内置类型2：自定义
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("enum_type")]
            public int EnumType { get; init; }

            	
            /// <summary>
            /// 使用状态
            /// 可选值有：
            /// 1：激活2：未激活
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("enum_status")]
            public int EnumStatus { get; init; }

            	
            /// <summary>
            /// i18n定义
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("i18n_content")]
            public I18nContent[] I18nContent { get; init; }
        }

        // i18n_content|locale:string||value:string|
        public class I18nContent
        {
            	
            /// <summary>
            /// 语言版本
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
            public string Locale { get; init; }

            	
            /// <summary>
            /// 字段名
            /// </summary>
            [global::System.Text.Json.Serialization.JsonPropertyName("value")]
            public string Value { get; init; }
        }
    }
}