#pragma checksum "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58c9e0e2302ab113e85acd880ce6a45906c060f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles__EditRoleModal), @"mvc.1.0.view", @"/Views/Roles/_EditRoleModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/_EditRoleModal.cshtml", typeof(AspNetCore.Views_Roles__EditRoleModal))]
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
#line 1 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
using MyProject.Web.Models.Common.Modals;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58c9e0e2302ab113e85acd880ce6a45906c060f0", @"/Views/Roles/_EditRoleModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b203b3f0805b4f117ac3d0d294f9ef72921dac8", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles__EditRoleModal : MyProject.Web.Views.MyProjectRazorPage<MyProject.Web.Models.Roles.EditRoleModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("RoleEditForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Roles/_EditRoleModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(124, 98, false);
#line 6 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("EditRole"))));

#line default
#line hidden
            EndContext();
            BeginContext(222, 31, true);
            WriteLiteral("\n\n<div class=\"modal-body\">\n    ");
            EndContext();
            BeginContext(253, 2486, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d17b10e0b6914c388bda7fce9112c588", async() => {
                BeginContext(326, 39, true);
                WriteLiteral("\n        <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 365, "\"", 387, 1);
#line 10 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 373, Model.Role.Id, 373, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(388, 48, true);
                WriteLiteral(" />\n        <input type=\"hidden\" name=\"IsStatic\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 436, "\"", 477, 1);
#line 11 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 444, Model.Role.IsStatic.ToString(), 444, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(478, 216, true);
                WriteLiteral(" />\n        <div class=\"row clearfix\">\n            <div class=\"col-sm-12\">\n                <div class=\"form-group form-float\">\n                    <div class=\"form-line\">\n                        <input id=\"rolename\" ");
                EndContext();
                BeginContext(696, 35, false);
#line 16 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                         Write(Model.Role.IsStatic ? "disabled":"");

#line default
#line hidden
                EndContext();
                BeginContext(732, 32, true);
                WriteLiteral(" type=\"text\" name=\"Name\" value=\"");
                EndContext();
                BeginContext(765, 15, false);
#line 16 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                                                              Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(780, 136, true);
                WriteLiteral("\" required maxlength=\"32\" minlength=\"2\" class=\"validate form-control\">\n                        <label for=\"rolename\" class=\"form-label\">");
                EndContext();
                BeginContext(917, 13, false);
#line 17 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                            Write(L("RoleName"));

#line default
#line hidden
                EndContext();
                BeginContext(930, 339, true);
                WriteLiteral(@"</label>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row clearfix"">
            <div class=""col-sm-12"">
                <div class=""form-group form-float"">
                    <div class=""form-line"">
                        <input id=""displayname"" type=""text"" name=""DisplayName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1269, "\"", 1300, 1);
#line 27 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 1277, Model.Role.DisplayName, 1277, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1301, 138, true);
                WriteLiteral(" required maxlength=\"32\" minlength=\"2\" class=\"validate form-control\">\n                        <label for=\"displayname\" class=\"form-label\">");
                EndContext();
                BeginContext(1440, 16, false);
#line 28 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                               Write(L("DisplayName"));

#line default
#line hidden
                EndContext();
                BeginContext(1456, 357, true);
                WriteLiteral(@"</label>
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""form-group form-float"">
                    <div class=""form-line"">
                        <textarea id=""role-description"" name=""Description"" class=""validate form-control"">");
                EndContext();
                BeginContext(1814, 22, false);
#line 38 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                                                    Write(Model.Role.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1836, 85, true);
                WriteLiteral("</textarea>\n                        <label for=\"role-description\" class=\"form-label\">");
                EndContext();
                BeginContext(1922, 20, false);
#line 39 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                    Write(L("RoleDescription"));

#line default
#line hidden
                EndContext();
                BeginContext(1942, 185, true);
                WriteLiteral("</label>\n                    </div>\n                </div>\n            </div>\n        </div>\n\n        <div class=\"row clearfix\">\n            <div class=\"col-sm-12\">\n                <h4>");
                EndContext();
                BeginContext(2128, 16, false);
#line 47 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
               Write(L("Permissions"));

#line default
#line hidden
                EndContext();
                BeginContext(2144, 7, true);
                WriteLiteral("</h4>\n\n");
                EndContext();
#line 49 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                 foreach (var permission in Model.Permissions)
                {

#line default
#line hidden
                BeginContext(2232, 107, true);
                WriteLiteral("                    <div class=\"col-sm-6\">\n                        <input type=\"checkbox\" name=\"permission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2339, "\"", 2363, 1);
#line 52 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 2347, permission.Name, 2347, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2364, 18, true);
                WriteLiteral(" class=\"filled-in\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2382, "\"", 2434, 1);
#line 52 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 2387, string.Format("permission{0}",permission.Name), 2387, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2435, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2438, 48, false);
#line 52 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                                                                                                             Write(Model.HasPermission(permission) ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2487, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2490, 37, false);
#line 52 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                                                                                                                                                                 Write(Model.Role.IsStatic ? "disabled" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2528, 34, true);
                WriteLiteral(" />\n                        <label");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 2562, "\"", 2615, 1);
#line 53 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
WriteAttributeValue("", 2568, string.Format("permission{0}",permission.Name), 2568, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2616, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2618, 22, false);
#line 53 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                                                                                Write(permission.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(2640, 36, true);
                WriteLiteral("</label>\n                    </div>\n");
                EndContext();
#line 55 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
                }

#line default
#line hidden
                BeginContext(2694, 38, true);
                WriteLiteral("            </div>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2739, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            BeginContext(2749, 74, false);
#line 61 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(2823, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(2825, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11e903ac0f634b1db7033142531c3b59", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 63 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Roles\_EditRoleModal.cshtml"
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
            BeginContext(2921, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProject.Web.Models.Roles.EditRoleModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
