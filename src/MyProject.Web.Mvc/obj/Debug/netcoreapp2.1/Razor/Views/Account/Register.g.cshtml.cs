#pragma checksum "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e34fe789dd74b2ce620c257608fcf07b23498af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 1 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e34fe789dd74b2ce620c257608fcf07b23498af", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b203b3f0805b4f117ac3d0d294f9ef72921dac8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : MyProject.Web.Views.MyProjectRazorPage<MyProject.Web.Models.Account.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/view-resources/Views/Account/Login.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/view-resources/Views/Account/Login.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Account/Register.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Account/Register.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default waves-effect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("RegisterForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
  
    ViewBag.DisableTopBar = true;

#line default
#line hidden
            DefineSection("Styles", async() => {
                BeginContext(141, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(146, 160, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c63bc796e984acc8fdae64afe376b54", async() => {
                    BeginContext(179, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(188, 99, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4cb32a5daba44f7689a8ef9d44f6c60f", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 9 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(287, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(306, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(312, 171, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb1e9ae2537d49d5af5c3e39153937db", async() => {
                    BeginContext(352, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(361, 103, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf9770b6a9a64af182bc08fae3817fa6", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 13 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(464, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(483, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(503, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(508, 153, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9702d3471bc2475d9b7c52feda9cabe4", async() => {
                    BeginContext(541, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(550, 92, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "204756451ad446e9866f16da51210590", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 18 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(642, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(661, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(667, 164, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51c53994f4124f169a3e32409d61aa76", async() => {
                    BeginContext(707, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(716, 96, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd67af50f48b44029a3f8d68d721e307", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 22 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(812, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(831, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(834, 50, true);
            WriteLiteral("<div class=\"card\">\n    <div class=\"body\">\n        ");
            EndContext();
            BeginContext(884, 2647, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dde31761c7df466e9be0fd28abd43daa", async() => {
                BeginContext(944, 37, true);
                WriteLiteral("\n            <h4 class=\"text-center\">");
                EndContext();
                BeginContext(982, 13, false);
#line 28 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
                               Write(L("Register"));

#line default
#line hidden
                EndContext();
                BeginContext(995, 7, true);
                WriteLiteral("</h4>\n\n");
                EndContext();
#line 30 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
             if (@ViewBag.ErrorMessage != null)
            {

#line default
#line hidden
                BeginContext(1064, 99, true);
                WriteLiteral("                <div class=\"alert alert-danger\">\n                    <i class=\"fa fa-warning\"></i> ");
                EndContext();
                BeginContext(1164, 20, false);
#line 33 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
                                             Write(ViewBag.ErrorMessage);

#line default
#line hidden
                EndContext();
                BeginContext(1184, 24, true);
                WriteLiteral("\n                </div>\n");
                EndContext();
#line 35 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
            }

#line default
#line hidden
                BeginContext(1222, 56, true);
                WriteLiteral("\n            <input type=\"hidden\" name=\"IsExternalLogin\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1278, "\"", 1319, 1);
#line 37 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1286, Model.IsExternalLogin.ToString(), 1286, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1320, 67, true);
                WriteLiteral(" />\n            <input type=\"hidden\" name=\"ExternalLoginAuthSchema\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1387, "\"", 1425, 1);
#line 38 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1395, Model.ExternalLoginAuthSchema, 1395, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1426, 164, true);
                WriteLiteral(" />\n\n            <div class=\"form-group form-float\">\n                <div class=\"form-line\">\n                    <input type=\"text\" class=\"form-control\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1590, "\"", 1609, 1);
#line 42 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1598, Model.Name, 1598, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1610, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1619, "\"", 1657, 1);
#line 42 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1631, AbpUserBase.MaxNameLength, 1631, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1658, 48, true);
                WriteLiteral(">\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(1707, 9, false);
#line 43 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("Name"));

#line default
#line hidden
                EndContext();
                BeginContext(1716, 214, true);
                WriteLiteral("</label>\n                </div>\n            </div>\n\n            <div class=\"form-group form-float\">\n                <div class=\"form-line\">\n                    <input type=\"text\" class=\"form-control\" name=\"Surname\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1930, "\"", 1952, 1);
#line 49 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1938, Model.Surname, 1938, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1953, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1962, "\"", 2003, 1);
#line 49 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1974, AbpUserBase.MaxSurnameLength, 1974, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2004, 48, true);
                WriteLiteral(">\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(2053, 12, false);
#line 50 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("Surname"));

#line default
#line hidden
                EndContext();
                BeginContext(2065, 220, true);
                WriteLiteral("</label>\n                </div>\n            </div>\n\n            <div class=\"form-group form-float\">\n                <div class=\"form-line\">\n                    <input type=\"email\" class=\"form-control\" name=\"EmailAddress\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2285, "\"", 2312, 1);
#line 56 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2293, Model.EmailAddress, 2293, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2313, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2322, "\"", 2368, 1);
#line 56 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2334, AbpUserBase.MaxEmailAddressLength, 2334, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2369, 48, true);
                WriteLiteral(">\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(2418, 17, false);
#line 57 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("EmailAddress"));

#line default
#line hidden
                EndContext();
                BeginContext(2435, 215, true);
                WriteLiteral("</label>\n                </div>\n            </div>\n\n            <div class=\"form-group form-float\">\n                <div class=\"form-line\">\n                    <input type=\"text\" class=\"form-control\" name=\"UserName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2650, "\"", 2673, 1);
#line 63 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2658, Model.UserName, 2658, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2674, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2683, "\"", 2725, 1);
#line 63 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2695, AbpUserBase.MaxUserNameLength, 2695, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2726, 48, true);
                WriteLiteral(">\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(2775, 13, false);
#line 64 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("UserName"));

#line default
#line hidden
                EndContext();
                BeginContext(2788, 228, true);
                WriteLiteral("</label>\n                </div>\n            </div>\n\n            <div class=\"form-group form-float\">\n                <div class=\"form-line\">\n                    <input type=\"password\" class=\"form-control\" name=\"Password\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 3016, "\"", 3063, 1);
#line 70 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 3028, AbpUserBase.MaxPlainPasswordLength, 3028, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3064, 48, true);
                WriteLiteral(">\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(3113, 13, false);
#line 71 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("Password"));

#line default
#line hidden
                EndContext();
                BeginContext(3126, 154, true);
                WriteLiteral("</label>\n                </div>\n            </div>\n            \n            <div class=\"row\">\n                <div class=\"col-xs-12\">\n                    ");
                EndContext();
                BeginContext(3280, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceeabc2269ff4ff8907a7c070680d94a", async() => {
                    BeginContext(3341, 9, false);
#line 77 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
                                                                           Write(L("Back"));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3354, 96, true);
                WriteLiteral("\n                    <button id=\"RegisterButton\" class=\"btn bg-pink waves-effect\" type=\"submit\">");
                EndContext();
                BeginContext(3451, 13, false);
#line 78 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\Register.cshtml"
                                                                                          Write(L("Register"));

#line default
#line hidden
                EndContext();
                BeginContext(3464, 60, true);
                WriteLiteral("</button>\n                </div>\n            </div>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3531, 19, true);
            WriteLiteral("\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProject.Web.Models.Account.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
