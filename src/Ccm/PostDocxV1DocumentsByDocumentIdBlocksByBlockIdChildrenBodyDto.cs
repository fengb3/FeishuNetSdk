using Newtonsoft.Json;
namespace FeishuNetSdk.Ccm;
/// <summary>
/// 创建块 请求体
/// <para>指定需要操作的块，为其创建一批子块，并插入到指定位置。如果操作成功，接口将返回新创建子块的富文本内容。</para>
/// <para>接口ID：7068199542315270172</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/docs/docx-v1/document-block/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuUDN04SN0QjL1QDN%2fdocument-docx%2fdocx-v1%2fdocument-block-children%2fcreate</para>
/// </summary>
public record PostDocxV1DocumentsByDocumentIdBlocksByBlockIdChildrenBodyDto
{
    /// <summary>
    /// <para>添加的孩子列表。</para>
    /// <para>必填：否</para>
    /// <para>最大长度：50</para>
    /// <para>最小长度：1</para>
    /// </summary>
    [JsonProperty("children")]
    public Block[]? Childrens { get; set; }

    /// <summary>
    /// <para>添加的孩子列表。</para>
    /// </summary>
    public record Block
    {
        /// <summary>
        /// <para>block 类型</para>
        /// <para>必填：是</para>
        /// <para>示例值：1</para>
        /// <para>可选值：<list type="bullet">
        /// <item>1：页面 Block</item>
        /// <item>2：文本 Block</item>
        /// <item>3：标题 1 Block</item>
        /// <item>4：标题 2 Block</item>
        /// <item>5：标题 3 Block</item>
        /// <item>6：标题 4 Block</item>
        /// <item>7：标题 5 Block</item>
        /// <item>8：标题 6 Block</item>
        /// <item>9：标题 7 Block</item>
        /// <item>10：标题 8 Block</item>
        /// <item>11：标题 9 Block</item>
        /// <item>12：无序列表 Block</item>
        /// <item>13：有序列表 Block</item>
        /// <item>14：代码块 Block</item>
        /// <item>15：引用 Block</item>
        /// <item>17：待办事项 Block</item>
        /// <item>18：多维表格 Block</item>
        /// <item>19：高亮块 Block</item>
        /// <item>20：会话卡片 Block</item>
        /// <item>21：流程图 &amp; UML Block</item>
        /// <item>22：分割线 Block</item>
        /// <item>23：文件 Block</item>
        /// <item>24：分栏 Block</item>
        /// <item>25：分栏列 Block</item>
        /// <item>26：内嵌 Block Block</item>
        /// <item>27：图片 Block</item>
        /// <item>28：开放平台小组件 Block</item>
        /// <item>29：思维笔记 Block</item>
        /// <item>30：电子表格 Block</item>
        /// <item>31：表格 Block</item>
        /// <item>32：表格单元格 Block</item>
        /// <item>33：视图 Block</item>
        /// <item>34：引用容器 Block</item>
        /// <item>35：任务 Block</item>
        /// <item>36：OKR Block</item>
        /// <item>37：OKR Objective Block</item>
        /// <item>38：OKR Key Result Block</item>
        /// <item>39：OKR 进展 Block</item>
        /// <item>40：文档小组件</item>
        /// <item>999：未支持 Block</item>
        /// </list></para>
        /// </summary>
        [JsonProperty("block_type")]
        public int BlockType { get; set; }

        /// <summary>
        /// <para>文本 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("text")]
        public BlockText? Text { get; set; }

        /// <summary>
        /// <para>文本 Block</para>
        /// </summary>
        public record BlockText
        {
            /// <summary>
            /// <para>文本样式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("style")]
            public TextStyle? Style { get; set; }

            /// <summary>
            /// <para>文本样式</para>
            /// </summary>
            public record TextStyle
            {
                /// <summary>
                /// <para>对齐方式</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：居左排版</item>
                /// <item>2：居中排版</item>
                /// <item>3：居右排版</item>
                /// </list></para>
                /// <para>默认值：1</para>
                /// </summary>
                [JsonProperty("align")]
                public int? Align { get; set; }

                /// <summary>
                /// <para>todo 的完成状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonProperty("done")]
                public bool? Done { get; set; }

                /// <summary>
                /// <para>文本的折叠状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonProperty("folded")]
                public bool? Folded { get; set; }

                /// <summary>
                /// <para>代码块语言</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：PlainText</item>
                /// <item>2：ABAP</item>
                /// <item>3：Ada</item>
                /// <item>4：Apache</item>
                /// <item>5：Apex</item>
                /// <item>6：Assembly Language</item>
                /// <item>7：Bash</item>
                /// <item>8：CSharp</item>
                /// <item>9：C++</item>
                /// <item>10：C</item>
                /// <item>11：COBOL</item>
                /// <item>12：CSS</item>
                /// <item>13：CoffeeScript</item>
                /// <item>14：D</item>
                /// <item>15：Dart</item>
                /// <item>16：Delphi</item>
                /// <item>17：Django</item>
                /// <item>18：Dockerfile</item>
                /// <item>19：Erlang</item>
                /// <item>20：Fortran</item>
                /// <item>21：FoxPro</item>
                /// <item>22：Go</item>
                /// <item>23：Groovy</item>
                /// <item>24：HTML</item>
                /// <item>25：HTMLBars</item>
                /// <item>26：HTTP</item>
                /// <item>27：Haskell</item>
                /// <item>28：JSON</item>
                /// <item>29：Java</item>
                /// <item>30：JavaScript</item>
                /// <item>31：Julia</item>
                /// <item>32：Kotlin</item>
                /// <item>33：LateX</item>
                /// <item>34：Lisp</item>
                /// <item>35：Logo</item>
                /// <item>36：Lua</item>
                /// <item>37：MATLAB</item>
                /// <item>38：Makefile</item>
                /// <item>39：Markdown</item>
                /// <item>40：Nginx</item>
                /// <item>41：Objective-C</item>
                /// <item>42：OpenEdgeABL</item>
                /// <item>43：PHP</item>
                /// <item>44：Perl</item>
                /// <item>45：PostScript</item>
                /// <item>46：Power Shell</item>
                /// <item>47：Prolog</item>
                /// <item>48：ProtoBuf</item>
                /// <item>49：Python</item>
                /// <item>50：R</item>
                /// <item>51：RPG</item>
                /// <item>52：Ruby</item>
                /// <item>53：Rust</item>
                /// <item>54：SAS</item>
                /// <item>55：SCSS</item>
                /// <item>56：SQL</item>
                /// <item>57：Scala</item>
                /// <item>58：Scheme</item>
                /// <item>59：Scratch</item>
                /// <item>60：Shell</item>
                /// <item>61：Swift</item>
                /// <item>62：Thrift</item>
                /// <item>63：TypeScript</item>
                /// <item>64：VBScript</item>
                /// <item>65：Visual Basic</item>
                /// <item>66：XML</item>
                /// <item>67：YAML</item>
                /// <item>68：CMake</item>
                /// <item>69：Diff</item>
                /// <item>70：Gherkin</item>
                /// <item>71：GraphQL</item>
                /// <item>72：OpenGL Shading Language</item>
                /// <item>73：Properties</item>
                /// <item>74：Solidity</item>
                /// <item>75：TOML</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("language")]
                public int? Language { get; set; }

                /// <summary>
                /// <para>代码块是否自动换行</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonProperty("wrap")]
                public bool? Wrap { get; set; }
            }

            /// <summary>
            /// <para>文本元素</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("elements")]
            public TextElement[] Elements { get; set; } = Array.Empty<TextElement>();

            /// <summary>
            /// <para>文本元素</para>
            /// </summary>
            public record TextElement
            {
                /// <summary>
                /// <para>文字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("text_run")]
                public TextElementTextRun? TextRun { get; set; }

                /// <summary>
                /// <para>文字</para>
                /// </summary>
                public record TextElementTextRun
                {
                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：文本</para>
                    /// </summary>
                    [JsonProperty("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementTextRunTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementTextRunTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementTextRunTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementTextRunTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@用户</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("mention_user")]
                public TextElementMentionUser? MentionUser { get; set; }

                /// <summary>
                /// <para>@用户</para>
                /// </summary>
                public record TextElementMentionUser
                {
                    /// <summary>
                    /// <para>用户 OpenID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                    /// </summary>
                    [JsonProperty("user_id")]
                    public string UserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementMentionUserTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionUserTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementMentionUserTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionUserTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@文档</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("mention_doc")]
                public TextElementMentionDoc? MentionDoc { get; set; }

                /// <summary>
                /// <para>@文档</para>
                /// </summary>
                public record TextElementMentionDoc
                {
                    /// <summary>
                    /// <para>云文档 token</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonProperty("token")]
                    public string Token { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>云文档类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：22</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：Doc</item>
                    /// <item>3：Sheet</item>
                    /// <item>8：Bitable</item>
                    /// <item>11：MindNote</item>
                    /// <item>12：File</item>
                    /// <item>15：Slide</item>
                    /// <item>16：Wiki</item>
                    /// <item>22：Docx</item>
                    /// </list></para>
                    /// </summary>
                    [JsonProperty("obj_type")]
                    public int ObjType { get; set; }

                    /// <summary>
                    /// <para>云文档链接（需要 url_encode)</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonProperty("url")]
                    public string Url { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementMentionDocTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionDocTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementMentionDocTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionDocTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>日期提醒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("reminder")]
                public TextElementReminder? Reminder { get; set; }

                /// <summary>
                /// <para>日期提醒</para>
                /// </summary>
                public record TextElementReminder
                {
                    /// <summary>
                    /// <para>创建者用户 ID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
                    /// </summary>
                    [JsonProperty("create_user_id")]
                    public string CreateUserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>是日期还是整点小时</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonProperty("is_whole_day")]
                    public bool? IsWholeDay { get; set; }

                    /// <summary>
                    /// <para>事件发生的时间（毫秒级时间戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1641967200000</para>
                    /// </summary>
                    [JsonProperty("expire_time")]
                    public string ExpireTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementReminderTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementReminderTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementReminderTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementReminderTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>内联附件</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("file")]
                public InlineFile? File { get; set; }

                /// <summary>
                /// <para>内联附件</para>
                /// </summary>
                public record InlineFile
                {
                    /// <summary>
                    /// <para>附件 token</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                    /// </summary>
                    [JsonProperty("file_token")]
                    public string? FileToken { get; set; }

                    /// <summary>
                    /// <para>当前文档中该附件所处的 block 的 id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：doxcnM46kSWSkgUMW04ldKsJDsc</para>
                    /// </summary>
                    [JsonProperty("source_block_id")]
                    public string? SourceBlockId { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public InlineFileTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record InlineFileTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public InlineFileTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record InlineFileTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>内联 block</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("inline_block")]
                public TextElementInlineBlock? InlineBlock { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// </summary>
                public record TextElementInlineBlock
                {
                    /// <summary>
                    /// <para>关联的内联状态的 block 的 block_id</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxcnPFi0R56ctbvh2MjkkROFWf</para>
                    /// </summary>
                    [JsonProperty("block_id")]
                    public string BlockId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementInlineBlockTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementInlineBlockTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementInlineBlockTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementInlineBlockTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>公式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("equation")]
                public TextElementEquation? Equation { get; set; }

                /// <summary>
                /// <para>公式</para>
                /// </summary>
                public record TextElementEquation
                {
                    /// <summary>
                    /// <para>符合 KaTeX 语法的公式内容，语法规则请参考：https://katex.org/docs/supported.html</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：E=mc^2\n</para>
                    /// </summary>
                    [JsonProperty("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementEquationTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementEquationTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementEquationTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementEquationTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>一级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("heading1")]
        public TextSuffix? Heading1 { get; set; }

        /// <summary>
        /// <para>一级标题 Block</para>
        /// </summary>
        public record TextSuffix
        {
            /// <summary>
            /// <para>文本样式</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("style")]
            public TextStyle? Style { get; set; }

            /// <summary>
            /// <para>文本样式</para>
            /// </summary>
            public record TextStyle
            {
                /// <summary>
                /// <para>对齐方式</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：居左排版</item>
                /// <item>2：居中排版</item>
                /// <item>3：居右排版</item>
                /// </list></para>
                /// <para>默认值：1</para>
                /// </summary>
                [JsonProperty("align")]
                public int? Align { get; set; }

                /// <summary>
                /// <para>todo 的完成状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonProperty("done")]
                public bool? Done { get; set; }

                /// <summary>
                /// <para>文本的折叠状态</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonProperty("folded")]
                public bool? Folded { get; set; }

                /// <summary>
                /// <para>代码块语言</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：PlainText</item>
                /// <item>2：ABAP</item>
                /// <item>3：Ada</item>
                /// <item>4：Apache</item>
                /// <item>5：Apex</item>
                /// <item>6：Assembly Language</item>
                /// <item>7：Bash</item>
                /// <item>8：CSharp</item>
                /// <item>9：C++</item>
                /// <item>10：C</item>
                /// <item>11：COBOL</item>
                /// <item>12：CSS</item>
                /// <item>13：CoffeeScript</item>
                /// <item>14：D</item>
                /// <item>15：Dart</item>
                /// <item>16：Delphi</item>
                /// <item>17：Django</item>
                /// <item>18：Dockerfile</item>
                /// <item>19：Erlang</item>
                /// <item>20：Fortran</item>
                /// <item>21：FoxPro</item>
                /// <item>22：Go</item>
                /// <item>23：Groovy</item>
                /// <item>24：HTML</item>
                /// <item>25：HTMLBars</item>
                /// <item>26：HTTP</item>
                /// <item>27：Haskell</item>
                /// <item>28：JSON</item>
                /// <item>29：Java</item>
                /// <item>30：JavaScript</item>
                /// <item>31：Julia</item>
                /// <item>32：Kotlin</item>
                /// <item>33：LateX</item>
                /// <item>34：Lisp</item>
                /// <item>35：Logo</item>
                /// <item>36：Lua</item>
                /// <item>37：MATLAB</item>
                /// <item>38：Makefile</item>
                /// <item>39：Markdown</item>
                /// <item>40：Nginx</item>
                /// <item>41：Objective-C</item>
                /// <item>42：OpenEdgeABL</item>
                /// <item>43：PHP</item>
                /// <item>44：Perl</item>
                /// <item>45：PostScript</item>
                /// <item>46：Power Shell</item>
                /// <item>47：Prolog</item>
                /// <item>48：ProtoBuf</item>
                /// <item>49：Python</item>
                /// <item>50：R</item>
                /// <item>51：RPG</item>
                /// <item>52：Ruby</item>
                /// <item>53：Rust</item>
                /// <item>54：SAS</item>
                /// <item>55：SCSS</item>
                /// <item>56：SQL</item>
                /// <item>57：Scala</item>
                /// <item>58：Scheme</item>
                /// <item>59：Scratch</item>
                /// <item>60：Shell</item>
                /// <item>61：Swift</item>
                /// <item>62：Thrift</item>
                /// <item>63：TypeScript</item>
                /// <item>64：VBScript</item>
                /// <item>65：Visual Basic</item>
                /// <item>66：XML</item>
                /// <item>67：YAML</item>
                /// <item>68：CMake</item>
                /// <item>69：Diff</item>
                /// <item>70：Gherkin</item>
                /// <item>71：GraphQL</item>
                /// <item>72：OpenGL Shading Language</item>
                /// <item>73：Properties</item>
                /// <item>74：Solidity</item>
                /// <item>75：TOML</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("language")]
                public int? Language { get; set; }

                /// <summary>
                /// <para>代码块是否自动换行</para>
                /// <para>必填：否</para>
                /// <para>示例值：true</para>
                /// <para>默认值：false</para>
                /// </summary>
                [JsonProperty("wrap")]
                public bool? Wrap { get; set; }
            }

            /// <summary>
            /// <para>文本元素</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("elements")]
            public TextElement[] Elements { get; set; } = Array.Empty<TextElement>();

            /// <summary>
            /// <para>文本元素</para>
            /// </summary>
            public record TextElement
            {
                /// <summary>
                /// <para>文字</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("text_run")]
                public TextElementTextRun? TextRun { get; set; }

                /// <summary>
                /// <para>文字</para>
                /// </summary>
                public record TextElementTextRun
                {
                    /// <summary>
                    /// <para>文本内容</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：文本</para>
                    /// </summary>
                    [JsonProperty("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementTextRunTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementTextRunTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementTextRunTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementTextRunTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@用户</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("mention_user")]
                public TextElementMentionUser? MentionUser { get; set; }

                /// <summary>
                /// <para>@用户</para>
                /// </summary>
                public record TextElementMentionUser
                {
                    /// <summary>
                    /// <para>用户 OpenID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：ou_3bbe8a09c20e89cce9bff989ed840674</para>
                    /// </summary>
                    [JsonProperty("user_id")]
                    public string UserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementMentionUserTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionUserTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementMentionUserTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionUserTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>@文档</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("mention_doc")]
                public TextElementMentionDoc? MentionDoc { get; set; }

                /// <summary>
                /// <para>@文档</para>
                /// </summary>
                public record TextElementMentionDoc
                {
                    /// <summary>
                    /// <para>云文档 token</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonProperty("token")]
                    public string Token { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>云文档类型</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：22</para>
                    /// <para>可选值：<list type="bullet">
                    /// <item>1：Doc</item>
                    /// <item>3：Sheet</item>
                    /// <item>8：Bitable</item>
                    /// <item>11：MindNote</item>
                    /// <item>12：File</item>
                    /// <item>15：Slide</item>
                    /// <item>16：Wiki</item>
                    /// <item>22：Docx</item>
                    /// </list></para>
                    /// </summary>
                    [JsonProperty("obj_type")]
                    public int ObjType { get; set; }

                    /// <summary>
                    /// <para>云文档链接（需要 url_encode)</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：https%3A%2F%2Fbytedance.feishu-boe.cn%2Fdocx%2Fdoxbc873Y7cXD153gXqb76G1Y9b</para>
                    /// </summary>
                    [JsonProperty("url")]
                    public string Url { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementMentionDocTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementMentionDocTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementMentionDocTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementMentionDocTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>日期提醒</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("reminder")]
                public TextElementReminder? Reminder { get; set; }

                /// <summary>
                /// <para>日期提醒</para>
                /// </summary>
                public record TextElementReminder
                {
                    /// <summary>
                    /// <para>创建者用户 ID</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：0e2633a3-aa1a-4171-af9e-0768ff863566</para>
                    /// </summary>
                    [JsonProperty("create_user_id")]
                    public string CreateUserId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>是日期还是整点小时</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：true</para>
                    /// <para>默认值：false</para>
                    /// </summary>
                    [JsonProperty("is_whole_day")]
                    public bool? IsWholeDay { get; set; }

                    /// <summary>
                    /// <para>事件发生的时间（毫秒级时间戳）</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：1641967200000</para>
                    /// </summary>
                    [JsonProperty("expire_time")]
                    public string ExpireTime { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementReminderTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementReminderTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementReminderTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementReminderTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>内联附件</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("file")]
                public InlineFile? File { get; set; }

                /// <summary>
                /// <para>内联附件</para>
                /// </summary>
                public record InlineFile
                {
                    /// <summary>
                    /// <para>附件 token</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：boxcnOj88GDkmWGm2zsTyCBqoLb</para>
                    /// </summary>
                    [JsonProperty("file_token")]
                    public string? FileToken { get; set; }

                    /// <summary>
                    /// <para>当前文档中该附件所处的 block 的 id</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：doxcnM46kSWSkgUMW04ldKsJDsc</para>
                    /// </summary>
                    [JsonProperty("source_block_id")]
                    public string? SourceBlockId { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public InlineFileTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record InlineFileTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public InlineFileTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record InlineFileTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>内联 block</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("inline_block")]
                public TextElementInlineBlock? InlineBlock { get; set; }

                /// <summary>
                /// <para>内联 block</para>
                /// </summary>
                public record TextElementInlineBlock
                {
                    /// <summary>
                    /// <para>关联的内联状态的 block 的 block_id</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：doxcnPFi0R56ctbvh2MjkkROFWf</para>
                    /// </summary>
                    [JsonProperty("block_id")]
                    public string BlockId { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementInlineBlockTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementInlineBlockTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementInlineBlockTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementInlineBlockTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }

                /// <summary>
                /// <para>公式</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("equation")]
                public TextElementEquation? Equation { get; set; }

                /// <summary>
                /// <para>公式</para>
                /// </summary>
                public record TextElementEquation
                {
                    /// <summary>
                    /// <para>符合 KaTeX 语法的公式内容，语法规则请参考：https://katex.org/docs/supported.html</para>
                    /// <para>必填：是</para>
                    /// <para>示例值：E=mc^2\n</para>
                    /// </summary>
                    [JsonProperty("content")]
                    public string Content { get; set; } = string.Empty;

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// <para>必填：否</para>
                    /// </summary>
                    [JsonProperty("text_element_style")]
                    public TextElementEquationTextElementStyle? TextElementStyle { get; set; }

                    /// <summary>
                    /// <para>文本局部样式</para>
                    /// </summary>
                    public record TextElementEquationTextElementStyle
                    {
                        /// <summary>
                        /// <para>加粗</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("bold")]
                        public bool? Bold { get; set; }

                        /// <summary>
                        /// <para>斜体</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("italic")]
                        public bool? Italic { get; set; }

                        /// <summary>
                        /// <para>删除线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("strikethrough")]
                        public bool? Strikethrough { get; set; }

                        /// <summary>
                        /// <para>下划线</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("underline")]
                        public bool? Underline { get; set; }

                        /// <summary>
                        /// <para>inline 代码</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：true</para>
                        /// <para>默认值：false</para>
                        /// </summary>
                        [JsonProperty("inline_code")]
                        public bool? InlineCode { get; set; }

                        /// <summary>
                        /// <para>背景色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：浅粉红色</item>
                        /// <item>2：浅橙色</item>
                        /// <item>3：浅黄色</item>
                        /// <item>4：浅绿色</item>
                        /// <item>5：浅蓝色</item>
                        /// <item>6：浅紫色</item>
                        /// <item>7：浅灰色</item>
                        /// <item>8：暗粉红色</item>
                        /// <item>9：暗橙色</item>
                        /// <item>10：暗黄色</item>
                        /// <item>11：暗绿色</item>
                        /// <item>12：暗蓝色</item>
                        /// <item>13：暗紫色</item>
                        /// <item>14：暗灰色</item>
                        /// <item>15：暗银灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("background_color")]
                        public int? BackgroundColor { get; set; }

                        /// <summary>
                        /// <para>字体颜色</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：1</para>
                        /// <para>可选值：<list type="bullet">
                        /// <item>1：粉红色</item>
                        /// <item>2：橙色</item>
                        /// <item>3：黄色</item>
                        /// <item>4：绿色</item>
                        /// <item>5：蓝色</item>
                        /// <item>6：紫色</item>
                        /// <item>7：灰色</item>
                        /// </list></para>
                        /// </summary>
                        [JsonProperty("text_color")]
                        public int? TextColor { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// <para>必填：否</para>
                        /// </summary>
                        [JsonProperty("link")]
                        public TextElementEquationTextElementStyleLink? Link { get; set; }

                        /// <summary>
                        /// <para>链接</para>
                        /// </summary>
                        public record TextElementEquationTextElementStyleLink
                        {
                            /// <summary>
                            /// <para>超链接指向的 url (需要 url_encode)</para>
                            /// <para>必填：是</para>
                            /// <para>示例值：https%3A%2F%2Fopen.feishu.cn%2F</para>
                            /// </summary>
                            [JsonProperty("url")]
                            public string Url { get; set; } = string.Empty;
                        }

                        /// <summary>
                        /// <para>评论 ID 列表。在创建 Block 时，不支持传入评论 ID；在更新文本 Block 的 Element 时，允许将对应版本已存在的评论 ID 移动到同一个 Block 内的任意 Element 中，但不支持传入新的评论 ID。如需查询评论内容请阅览「[获取评论](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/drive-v1/file-comment/get)」。</para>
                        /// <para>必填：否</para>
                        /// <para>示例值：["1660030311959965796"]</para>
                        /// </summary>
                        [JsonProperty("comment_ids")]
                        public string[]? CommentIds { get; set; }
                    }
                }
            }
        }

        /// <summary>
        /// <para>二级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("heading2")]
        public TextSuffix? Heading2 { get; set; }

        /// <summary>
        /// <para>三级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("heading3")]
        public TextSuffix? Heading3 { get; set; }

        /// <summary>
        /// <para>四级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("heading4")]
        public TextSuffix? Heading4 { get; set; }

        /// <summary>
        /// <para>五级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("heading5")]
        public TextSuffix? Heading5 { get; set; }

        /// <summary>
        /// <para>六级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("heading6")]
        public TextSuffix? Heading6 { get; set; }

        /// <summary>
        /// <para>七级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("heading7")]
        public TextSuffix? Heading7 { get; set; }

        /// <summary>
        /// <para>八级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("heading8")]
        public TextSuffix? Heading8 { get; set; }

        /// <summary>
        /// <para>九级标题 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("heading9")]
        public TextSuffix? Heading9 { get; set; }

        /// <summary>
        /// <para>无序列表 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("bullet")]
        public TextSuffix? Bullet { get; set; }

        /// <summary>
        /// <para>有序列表 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("ordered")]
        public TextSuffix? Ordered { get; set; }

        /// <summary>
        /// <para>代码块 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("code")]
        public TextSuffix? Code { get; set; }

        /// <summary>
        /// <para>引用 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("quote")]
        public TextSuffix? Quote { get; set; }

        /// <summary>
        /// <para>公式 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("equation")]
        public TextSuffix? Equation { get; set; }

        /// <summary>
        /// <para>待办事项 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("todo")]
        public TextSuffix? Todo { get; set; }

        /// <summary>
        /// <para>多维表格 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("bitable")]
        public BlockBitable? Bitable { get; set; }

        /// <summary>
        /// <para>多维表格 Block</para>
        /// </summary>
        public record BlockBitable
        {
            /// <summary>
            /// <para>类型</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：数据表</item>
            /// <item>2：看板</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("view_type")]
            public int? ViewType { get; set; }
        }

        /// <summary>
        /// <para>高亮块 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("callout")]
        public BlockCallout? Callout { get; set; }

        /// <summary>
        /// <para>高亮块 Block</para>
        /// </summary>
        public record BlockCallout
        {
            /// <summary>
            /// <para>高亮块背景色</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：浅红色</item>
            /// <item>2：浅橙色</item>
            /// <item>3：浅黄色</item>
            /// <item>4：浅绿色</item>
            /// <item>5：浅蓝色</item>
            /// <item>6：浅紫色</item>
            /// <item>7：浅灰色</item>
            /// <item>8：暗红色</item>
            /// <item>9：暗橙色</item>
            /// <item>10：暗黄色</item>
            /// <item>11：暗绿色</item>
            /// <item>12：暗蓝色</item>
            /// <item>13：暗紫色</item>
            /// <item>14：暗灰色</item>
            /// <item>15：暗银灰色</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("background_color")]
            public int? BackgroundColor { get; set; }

            /// <summary>
            /// <para>边框色</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：红色</item>
            /// <item>2：橙色</item>
            /// <item>3：黄色</item>
            /// <item>4：绿色</item>
            /// <item>5：蓝色</item>
            /// <item>6：紫色</item>
            /// <item>7：灰色</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("border_color")]
            public int? BorderColor { get; set; }

            /// <summary>
            /// <para>文字颜色</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：粉红色</item>
            /// <item>2：橙色</item>
            /// <item>3：黄色</item>
            /// <item>4：绿色</item>
            /// <item>5：蓝色</item>
            /// <item>6：紫色</item>
            /// <item>7：灰色</item>
            /// </list></para>
            /// </summary>
            [JsonProperty("text_color")]
            public int? TextColor { get; set; }
        }

        /// <summary>
        /// <para>群聊卡片 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("chat_card")]
        public BlockChatCard? ChatCard { get; set; }

        /// <summary>
        /// <para>群聊卡片 Block</para>
        /// </summary>
        public record BlockChatCard
        {
            /// <summary>
            /// <para>群聊天会话 ID</para>
            /// <para>必填：是</para>
            /// <para>示例值：7052227140476993555</para>
            /// </summary>
            [JsonProperty("chat_id")]
            public string ChatId { get; set; } = string.Empty;

            /// <summary>
            /// <para>对齐方式</para>
            /// <para>必填：否</para>
            /// <para>示例值：1</para>
            /// <para>可选值：<list type="bullet">
            /// <item>1：居左排版</item>
            /// <item>2：居中排版</item>
            /// <item>3：居右排版</item>
            /// </list></para>
            /// <para>默认值：1</para>
            /// </summary>
            [JsonProperty("align")]
            public int? Align { get; set; }
        }

        /// <summary>
        /// <para>分割线 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("divider")]
        public object? Divider { get; set; }

        /// <summary>
        /// <para>文件 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("file")]
        public object? File { get; set; }

        /// <summary>
        /// <para>分栏 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("grid")]
        public BlockGrid? Grid { get; set; }

        /// <summary>
        /// <para>分栏 Block</para>
        /// </summary>
        public record BlockGrid
        {
            /// <summary>
            /// <para>分栏列数量</para>
            /// <para>必填：是</para>
            /// <para>示例值：2</para>
            /// <para>最大值：5</para>
            /// <para>最小值：2</para>
            /// </summary>
            [JsonProperty("column_size")]
            public int ColumnSize { get; set; }
        }

        /// <summary>
        /// <para>内嵌 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("iframe")]
        public BlockIframe? Iframe { get; set; }

        /// <summary>
        /// <para>内嵌 Block</para>
        /// </summary>
        public record BlockIframe
        {
            /// <summary>
            /// <para>iframe 的组成元素</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("component")]
            public IframeComponent Component { get; set; } = new();

            /// <summary>
            /// <para>iframe 的组成元素</para>
            /// </summary>
            public record IframeComponent
            {
                /// <summary>
                /// <para>iframe 类型</para>
                /// <para>必填：否</para>
                /// <para>示例值：1</para>
                /// <para>可选值：<list type="bullet">
                /// <item>1：哔哩哔哩</item>
                /// <item>2：西瓜视频</item>
                /// <item>3：优酷</item>
                /// <item>4：Airtable</item>
                /// <item>5：百度地图</item>
                /// <item>6：高德地图</item>
                /// <item>7：Undefined</item>
                /// <item>8：Figma</item>
                /// <item>9：墨刀</item>
                /// <item>10：Canva</item>
                /// <item>11：CodePen</item>
                /// <item>12：飞书问卷</item>
                /// <item>13：金数据</item>
                /// <item>14：Undefined</item>
                /// <item>15：Undefined</item>
                /// <item>99：Other</item>
                /// </list></para>
                /// </summary>
                [JsonProperty("iframe_type")]
                public int? IframeType { get; set; }

                /// <summary>
                /// <para>iframe 目标 url（需要进行 url_encode）</para>
                /// <para>必填：是</para>
                /// <para>示例值：https%3A%2F%2Fwww.bilibili.com%2Fvideo%2FBV1Hi4y1w7V7</para>
                /// </summary>
                [JsonProperty("url")]
                public string Url { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// <para>图片 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("image")]
        public object? Image { get; set; }

        /// <summary>
        /// <para>三方 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("isv")]
        public object? Isv { get; set; }

        /// <summary>
        /// <para>Add-ons</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("add_ons")]
        public BlockAddOns? AddOns { get; set; }

        /// <summary>
        /// <para>Add-ons</para>
        /// </summary>
        public record BlockAddOns
        {
            /// <summary>
            /// <para>文档小组件 ID</para>
            /// <para>必填：否</para>
            /// <para>示例值：7056882725002051603</para>
            /// </summary>
            [JsonProperty("component_id")]
            public string? ComponentId { get; set; }

            /// <summary>
            /// <para>文档小组件类型，比如问答互动"blk_636a0a6657db8001c8df5488"</para>
            /// <para>必填：是</para>
            /// <para>示例值：blk_636a0a6657db8001c8df5488</para>
            /// </summary>
            [JsonProperty("component_type_id")]
            public string ComponentTypeId { get; set; } = string.Empty;

            /// <summary>
            /// <para>文档小组件内容数据，JSON 字符串</para>
            /// <para>必填：否</para>
            /// <para>示例值："{}"</para>
            /// </summary>
            [JsonProperty("record")]
            public string? Record { get; set; }
        }

        /// <summary>
        /// <para>电子表格 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("sheet")]
        public BlockSheet? Sheet { get; set; }

        /// <summary>
        /// <para>电子表格 Block</para>
        /// </summary>
        public record BlockSheet
        {
            /// <summary>
            /// <para>电子表格行数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>最大值：9</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonProperty("row_size")]
            public int? RowSize { get; set; }

            /// <summary>
            /// <para>电子表格列数量</para>
            /// <para>必填：否</para>
            /// <para>示例值：2</para>
            /// <para>最大值：9</para>
            /// <para>最小值：1</para>
            /// </summary>
            [JsonProperty("column_size")]
            public int? ColumnSize { get; set; }
        }

        /// <summary>
        /// <para>表格 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("table")]
        public BlockTable? Table { get; set; }

        /// <summary>
        /// <para>表格 Block</para>
        /// </summary>
        public record BlockTable
        {
            /// <summary>
            /// <para>表格属性</para>
            /// <para>必填：是</para>
            /// </summary>
            [JsonProperty("property")]
            public TableProperty Property { get; set; } = new();

            /// <summary>
            /// <para>表格属性</para>
            /// </summary>
            public record TableProperty
            {
                /// <summary>
                /// <para>行数</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>最大值：9</para>
                /// <para>最小值：1</para>
                /// </summary>
                [JsonProperty("row_size")]
                public int RowSize { get; set; }

                /// <summary>
                /// <para>列数</para>
                /// <para>必填：是</para>
                /// <para>示例值：1</para>
                /// <para>最大值：9</para>
                /// <para>最小值：1</para>
                /// </summary>
                [JsonProperty("column_size")]
                public int ColumnSize { get; set; }

                /// <summary>
                /// <para>单元格合并信息。在创建 Table 时候此属性是只读的，将由后端进行生成。如果需要对单元格进行合并操作，可以通过更新块的子请求 merge_table_cells 来实现。</para>
                /// <para>必填：否</para>
                /// </summary>
                [JsonProperty("merge_info")]
                public TableMergeInfo[]? MergeInfos { get; set; }

                /// <summary>
                /// <para>单元格合并信息。在创建 Table 时候此属性是只读的，将由后端进行生成。如果需要对单元格进行合并操作，可以通过更新块的子请求 merge_table_cells 来实现。</para>
                /// </summary>
                public record TableMergeInfo
                {
                    /// <summary>
                    /// <para>从当前行索引起被合并的连续行数</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：2</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonProperty("row_span")]
                    public int? RowSpan { get; set; }

                    /// <summary>
                    /// <para>从当前列索引起被合并的连续列数</para>
                    /// <para>必填：否</para>
                    /// <para>示例值：2</para>
                    /// <para>最小值：1</para>
                    /// </summary>
                    [JsonProperty("col_span")]
                    public int? ColSpan { get; set; }
                }
            }
        }

        /// <summary>
        /// <para>引用容器 Block</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("quote_container")]
        public object? QuoteContainer { get; set; }

        /// <summary>
        /// <para>OKR Block，仅可在使用 `user_access_token` 时创建</para>
        /// <para>必填：否</para>
        /// </summary>
        [JsonProperty("okr")]
        public BlockOkr? Okr { get; set; }

        /// <summary>
        /// <para>OKR Block，仅可在使用 `user_access_token` 时创建</para>
        /// </summary>
        public record BlockOkr
        {
            /// <summary>
            /// <para>OKR ID，获取需要插入的 OKR ID 可见[获取用户的 OKR 列表](https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/reference/okr-v1/user-okr/list)</para>
            /// <para>必填：否</para>
            /// <para>示例值：7076349900476448796</para>
            /// </summary>
            [JsonProperty("okr_id")]
            public string? OkrId { get; set; }

            /// <summary>
            /// <para>OKR Block 中的 Objective ID 和 Key Result ID，此值为空时插入 OKR 下所有的 Objective 和 Key Result</para>
            /// <para>必填：否</para>
            /// </summary>
            [JsonProperty("objectives")]
            public ObjectiveIdWithKrId[]? Objectives { get; set; }

            /// <summary>
            /// <para>OKR Block 中的 Objective ID 和 Key Result ID，此值为空时插入 OKR 下所有的 Objective 和 Key Result</para>
            /// </summary>
            public record ObjectiveIdWithKrId
            {
                /// <summary>
                /// <para>OKR 中 Objective 的 ID</para>
                /// <para>必填：否</para>
                /// <para>示例值：7109022409227026460</para>
                /// </summary>
                [JsonProperty("objective_id")]
                public string? ObjectiveId { get; set; }

                /// <summary>
                /// <para>Key Result 的 ID 列表，此值为空时插入当前 Objective 下的所有 Key Result</para>
                /// <para>必填：否</para>
                /// <para>示例值：["7109022573011894300","7109022546444517404"]</para>
                /// </summary>
                [JsonProperty("kr_ids")]
                public string[]? KrIds { get; set; }
            }
        }

        /// <summary>
        /// <para>评论 id 列表</para>
        /// <para>必填：否</para>
        /// <para>示例值：[1660030311959965796]</para>
        /// </summary>
        [JsonProperty("comment_ids")]
        public string[]? CommentIds { get; set; }
    }

    /// <summary>
    /// <para>当前 block 在 children 中的插入位置，起始值为 0，最大值为原 children 长度</para>
    /// <para>必填：否</para>
    /// <para>示例值：0</para>
    /// <para>默认值：-1</para>
    /// </summary>
    [JsonProperty("index")]
    public int? Index { get; set; }
}