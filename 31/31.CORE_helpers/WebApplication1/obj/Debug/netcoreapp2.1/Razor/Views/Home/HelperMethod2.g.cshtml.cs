#pragma checksum "D:\ЮЛЯ\ЭКЗАМЕН\31\31.CORE_helpers\WebApplication1\Views\Home\HelperMethod2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d04286c8f4f7683560503dc04ffd00665422b12c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HelperMethod2), @"mvc.1.0.view", @"/Views/Home/HelperMethod2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/HelperMethod2.cshtml", typeof(AspNetCore.Views_Home_HelperMethod2))]
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
#line 1 "D:\ЮЛЯ\ЭКЗАМЕН\31\31.CORE_helpers\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\ЮЛЯ\ЭКЗАМЕН\31\31.CORE_helpers\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04286c8f4f7683560503dc04ffd00665422b12c", @"/Views/Home/HelperMethod2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637209e7eeedf13d00f2cccd93a350b795d01eb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HelperMethod2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "D:\ЮЛЯ\ЭКЗАМЕН\31\31.CORE_helpers\WebApplication1\Views\Home\HelperMethod2.cshtml"
  
    Layout = null;
    ViewData["Title"] = "HelperMethod2";

#line default
#line hidden
            BeginContext(66, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(67, 338, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e40955ac4454560a11d940b072bbe5f", async() => {
                BeginContext(73, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 9 "D:\ЮЛЯ\ЭКЗАМЕН\31\31.CORE_helpers\WebApplication1\Views\Home\HelperMethod2.cshtml"
     using (Html.BeginForm("A21", "VDemo", FormMethod.Post))
    {

#line default
#line hidden
                BeginContext(228, 44, true);
                WriteLiteral("        <p>\n            <label>Name</label> ");
                EndContext();
                BeginContext(273, 20, false);
#line 12 "D:\ЮЛЯ\ЭКЗАМЕН\31\31.CORE_helpers\WebApplication1\Views\Home\HelperMethod2.cshtml"
                           Write(Html.TextBox("Name"));

#line default
#line hidden
                EndContext();
                BeginContext(293, 61, true);
                WriteLiteral("\n        </p>\n        <p>\n            <label>Surname</label> ");
                EndContext();
                BeginContext(355, 23, false);
#line 15 "D:\ЮЛЯ\ЭКЗАМЕН\31\31.CORE_helpers\WebApplication1\Views\Home\HelperMethod2.cshtml"
                              Write(Html.TextBox("Surname"));

#line default
#line hidden
                EndContext();
                BeginContext(378, 14, true);
                WriteLiteral("\n        </p>\n");
                EndContext();
#line 17 "D:\ЮЛЯ\ЭКЗАМЕН\31\31.CORE_helpers\WebApplication1\Views\Home\HelperMethod2.cshtml"
    }

#line default
#line hidden
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
            BeginContext(405, 2, true);
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
