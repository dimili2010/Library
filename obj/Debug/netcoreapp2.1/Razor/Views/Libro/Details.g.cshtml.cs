#pragma checksum "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f1092bf4eeaff54ce8649bec34721314cd8456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libro_Details), @"mvc.1.0.view", @"/Views/Libro/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Libro/Details.cshtml", typeof(AspNetCore.Views_Libro_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f1092bf4eeaff54ce8649bec34721314cd8456", @"/Views/Libro/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Libro_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Libro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(52, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(77, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6839725c62a34ee0a4da0656df329a8f", async() => {
                BeginContext(83, 88, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Details</title>  \n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(178, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(179, 1519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7ee155987434f748b740b91cc03d7ef", async() => {
                BeginContext(185, 88, true);
                WriteLiteral("\r\n    <div>\r\n        <div>\r\n            <div>\r\n                <p>\r\n                    ");
                EndContext();
                BeginContext(274, 42, false);
#line 18 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
                EndContext();
                BeginContext(316, 31, true);
                WriteLiteral(" &nbsp;\r\n\r\n                    ");
                EndContext();
                BeginContext(348, 38, false);
#line 20 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
                EndContext();
                BeginContext(386, 104, true);
                WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div>\r\n                <p>\r\n                    ");
                EndContext();
                BeginContext(491, 44, false);
#line 25 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Sinapsis));

#line default
#line hidden
                EndContext();
                BeginContext(535, 31, true);
                WriteLiteral(" &nbsp;\r\n\r\n                    ");
                EndContext();
                BeginContext(567, 40, false);
#line 27 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayFor(model => model.Sinapsis));

#line default
#line hidden
                EndContext();
                BeginContext(607, 104, true);
                WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div>\r\n                <p>\r\n                    ");
                EndContext();
                BeginContext(712, 46, false);
#line 32 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NumPaginas));

#line default
#line hidden
                EndContext();
                BeginContext(758, 31, true);
                WriteLiteral(" &nbsp;\r\n\r\n                    ");
                EndContext();
                BeginContext(790, 42, false);
#line 34 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayFor(model => model.NumPaginas));

#line default
#line hidden
                EndContext();
                BeginContext(832, 106, true);
                WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div>\r\n                <p>\r\n                    ");
                EndContext();
                BeginContext(939, 48, false);
#line 40 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Autor.Nombre));

#line default
#line hidden
                EndContext();
                BeginContext(987, 31, true);
                WriteLiteral(" &nbsp;\r\n\r\n                    ");
                EndContext();
                BeginContext(1019, 44, false);
#line 42 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayFor(model => model.Autor.Nombre));

#line default
#line hidden
                EndContext();
                BeginContext(1063, 11, true);
                WriteLiteral("   &nbsp;  ");
                EndContext();
                BeginContext(1075, 47, false);
#line 42 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
                                                                       Write(Html.DisplayFor(model => model.Autor.Apellidos));

#line default
#line hidden
                EndContext();
                BeginContext(1122, 106, true);
                WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div>\r\n                <p>\r\n                    ");
                EndContext();
                BeginContext(1229, 52, false);
#line 48 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Editorial.Nombre));

#line default
#line hidden
                EndContext();
                BeginContext(1281, 31, true);
                WriteLiteral(" &nbsp;\r\n\r\n                    ");
                EndContext();
                BeginContext(1313, 48, false);
#line 50 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayFor(model => model.Editorial.Nombre));

#line default
#line hidden
                EndContext();
                BeginContext(1361, 33, true);
                WriteLiteral("   &nbsp;\r\n\r\n                    ");
                EndContext();
                BeginContext(1395, 50, false);
#line 52 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Editorial.Sede));

#line default
#line hidden
                EndContext();
                BeginContext(1445, 31, true);
                WriteLiteral(" &nbsp;\r\n\r\n                    ");
                EndContext();
                BeginContext(1477, 46, false);
#line 54 "D:\Microservicios\Library\Library\Library\Views\Libro\Details.cshtml"
               Write(Html.DisplayFor(model => model.Editorial.Sede));

#line default
#line hidden
                EndContext();
                BeginContext(1523, 79, true);
                WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(1602, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62eb45f00b5c453da8be776e15e739e1", async() => {
                    BeginContext(1624, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1640, 51, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>  \n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1698, 9, true);
            WriteLiteral("\n</html>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Libro> Html { get; private set; }
    }
}
#pragma warning restore 1591
