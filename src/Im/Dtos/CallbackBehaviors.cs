﻿namespace FeishuNetSdk.Im.Dtos
{
    /// <summary>
    /// 服务端回传交互
    /// </summary>
    /// <param name="Value">你可在交互事件中自定义回传数据，支持 string 或 object 数据类型。</param>
    public record CallbackBehaviors([property: JsonPropertyName("value")] object? Value = null) : Behaviors("callback");
}
