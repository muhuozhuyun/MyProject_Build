#pragma checksum "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9a033c78ada61a6aaf0f6bdce7d3af08b54ddb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBarUserArea_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBarUserArea/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SideBarUserArea/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_SideBarUserArea_Default))]
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
#line 1 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml"
using MyProject.Web.Views.Shared.Components.SideBarUserArea;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9a033c78ada61a6aaf0f6bdce7d3af08b54ddb", @"/Views/Shared/Components/SideBarUserArea/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b203b3f0805b4f117ac3d0d294f9ef72921dac8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideBarUserArea_Default : MyProject.Web.Views.MyProjectRazorPage<SideBarUserAreaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("48"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("48"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(93, 56, true);
            WriteLiteral("<div class=\"user-info\">\n    <div class=\"image\">\n        ");
            EndContext();
            BeginContext(149, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e5f904315d448a8b3a5f63a7b9c3975", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(214, 137, true);
            WriteLiteral("\n    </div>\n    <div class=\"info-container\">\n        <div class=\"name\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">");
            EndContext();
            BeginContext(352, 35, false);
#line 8 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml"
                                                                                       Write(Html.Raw(Model.GetShownLoginName()));

#line default
#line hidden
            EndContext();
            BeginContext(387, 34, true);
            WriteLiteral("</div>\n        <div class=\"email\">");
            EndContext();
            BeginContext(422, 41, false);
#line 9 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml"
                      Write(Model.LoginInformations.User.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(463, 259, true);
            WriteLiteral(@"</div>
        <div class=""btn-group user-helper-dropdown"">
            <i class=""material-icons"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">keyboard_arrow_down</i>
            <ul class=""dropdown-menu pull-right"">
                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 722, "\"", 789, 1);
#line 13 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml"
WriteAttributeValue("", 729, Url.Action("Logout", "Account", new { area= string.Empty }), 729, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(790, 36, true);
            WriteLiteral("><i class=\"material-icons\">input</i>");
            EndContext();
            BeginContext(827, 11, false);
#line 13 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Shared\Components\SideBarUserArea\Default.cshtml"
                                                                                                                         Write(L("Logout"));

#line default
#line hidden
            EndContext();
            BeginContext(838, 61, true);
            WriteLiteral("</a></li>\n            </ul>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SideBarUserAreaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
