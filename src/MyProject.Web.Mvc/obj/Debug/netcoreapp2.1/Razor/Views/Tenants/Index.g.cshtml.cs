#pragma checksum "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e9615aa3d15e7993818a400814cdcf71124f50a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenants_Index), @"mvc.1.0.view", @"/Views/Tenants/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tenants/Index.cshtml", typeof(AspNetCore.Views_Tenants_Index))]
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
#line 1 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
#line 2 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#line 3 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
using MyProject.MultiTenancy;

#line default
#line hidden
#line 4 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
using MyProject.Web.Startup;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e9615aa3d15e7993818a400814cdcf71124f50a", @"/Views/Tenants/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b203b3f0805b4f117ac3d0d294f9ef72921dac8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenants_Index : MyProject.Web.Views.MyProjectRazorPage<Abp.Application.Services.Dto.PagedResultDto<MyProject.MultiTenancy.Dto.TenantDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Tenants/Index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Tenants/Index.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("tenantCreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
  
    ViewBag.CurrentPageName = PageNames.Tenants; // The menu item will be active for this page.

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(322, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(327, 150, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cb729e6d29c4f7bba4c536e6dee1f9f", async() => {
                    BeginContext(360, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(369, 89, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8b860e99b5b43dd83f36a4ce5bab94f", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 12 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
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
                    BeginContext(458, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(477, 6, true);
                WriteLiteral("\n\n    ");
                EndContext();
                BeginContext(483, 161, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0da7506fe54c4e8eaa13170b2c31ada1", async() => {
                    BeginContext(523, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(532, 93, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9d0119b2fc34b3196d3fe4098953213", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 16 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
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
                    BeginContext(625, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(644, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(647, 186, true);
            WriteLiteral("<div class=\"row clearfix\">\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\n        <div class=\"card\">\n            <div class=\"header\">\n                <h2>\n                    ");
            EndContext();
            BeginContext(834, 12, false);
#line 24 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
               Write(L("Tenants"));

#line default
#line hidden
            EndContext();
            BeginContext(846, 586, true);
            WriteLiteral(@"
                </h2>
                <ul class=""header-dropdown m-r--5"">
                    <li class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">more_vert</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li><a id=""RefreshButton"" href=""javascript:void(0);"" class=""waves-effect waves-block""><i class=""material-icons"">refresh</i>");
            EndContext();
            BeginContext(1433, 12, false);
#line 32 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                                                  Write(L("Refresh"));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 282, true);
            WriteLiteral(@"</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""body table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>");
            EndContext();
            BeginContext(1728, 16, false);
#line 41 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                           Write(L("TenancyName"));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1783, 9, false);
#line 42 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                           Write(L("Name"));

#line default
#line hidden
            EndContext();
            BeginContext(1792, 38, true);
            WriteLiteral("</th>\n                            <th>");
            EndContext();
            BeginContext(1831, 13, false);
#line 43 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                           Write(L("IsActive"));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 93, true);
            WriteLiteral("</th>\n                        </tr>\n                    </thead>\n                    <tbody>\n");
            EndContext();
#line 47 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                         foreach (var tenant in Model.Items)
                        {

#line default
#line hidden
            BeginContext(2024, 69, true);
            WriteLiteral("                            <tr>\n                                <td>");
            EndContext();
            BeginContext(2094, 18, false);
#line 50 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                               Write(tenant.TenancyName);

#line default
#line hidden
            EndContext();
            BeginContext(2112, 42, true);
            WriteLiteral("</td>\n                                <td>");
            EndContext();
            BeginContext(2155, 11, false);
#line 51 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                               Write(tenant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2166, 67, true);
            WriteLiteral("</td>\n                                <td><i class=\"material-icons\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2233, "\"", 2282, 3);
            WriteAttributeValue("", 2241, "color:", 2241, 6, true);
#line 52 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
WriteAttributeValue("", 2247, tenant.IsActive ? "green":"red", 2247, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 2281, ";", 2281, 1, true);
            EndWriteAttribute();
            BeginContext(2283, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2286, 57, false);
#line 52 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                            Write(tenant.IsActive ? "check_box" : "indeterminate_check_box");

#line default
#line hidden
            EndContext();
            BeginContext(2344, 524, true);
            WriteLiteral(@"</i></td>
                                <td class=""dropdown"">
                                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                        <i class=""material-icons"">menu</i>
                                    </a>
                                    <ul class=""dropdown-menu pull-right"">
                                        <li><a href=""#"" class=""waves-effect waves-block edit-tenant"" data-tenant-id=""");
            EndContext();
            BeginContext(2869, 9, false);
#line 58 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                Write(tenant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2878, 87, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#TenantEditModal\"><i class=\"material-icons\">edit</i>");
            EndContext();
            BeginContext(2966, 9, false);
#line 58 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                                                                                                                 Write(L("Edit"));

#line default
#line hidden
            EndContext();
            BeginContext(2975, 129, true);
            WriteLiteral("</a></li>\n                                        <li><a href=\"#\" class=\"waves-effect waves-block delete-tenant\" data-tenant-id=\"");
            EndContext();
            BeginContext(3105, 9, false);
#line 59 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                  Write(tenant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3114, 21, true);
            WriteLiteral("\" data-tenancy-name=\"");
            EndContext();
            BeginContext(3136, 18, false);
#line 59 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                                                 Write(tenant.TenancyName);

#line default
#line hidden
            EndContext();
            BeginContext(3154, 44, true);
            WriteLiteral("\"><i class=\"material-icons\">delete_sweep</i>");
            EndContext();
            BeginContext(3199, 11, false);
#line 59 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                                                                                                                                                Write(L("Delete"));

#line default
#line hidden
            EndContext();
            BeginContext(3210, 124, true);
            WriteLiteral("</a></li>\n                                    </ul>\n                                </td>\n                            </tr>\n");
            EndContext();
#line 63 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3360, 598, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <button type=""button"" class=""btn btn-primary btn-circle waves-effect waves-circle waves-float pull-right"" data-toggle=""modal"" data-target=""#TenantCreateModal"">
                    <i class=""material-icons"">add</i>
                </button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""TenantCreateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""TenantCreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            ");
            EndContext();
            BeginContext(3958, 2606, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c47b5909e5fe4f47a140fa22d6804b8f", async() => {
                BeginContext(4035, 119, true);
                WriteLiteral("\n                <div class=\"modal-header\">\n                    <h4 class=\"modal-title\">\n                        <span>");
                EndContext();
                BeginContext(4155, 20, false);
#line 80 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                         Write(L("CreateNewTenant"));

#line default
#line hidden
                EndContext();
                BeginContext(4175, 297, true);
                WriteLiteral(@"</span>
                    </h4>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group form-float"">
                        <div class=""form-line"">
                            <input class=""form-control"" type=""text"" name=""TenancyName"" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 4472, "\"", 4519, 1);
#line 86 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
WriteAttributeValue("", 4484, AbpTenantBase.MaxTenancyNameLength, 4484, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4520, 70, true);
                WriteLiteral(" minlength=\"2\">\n                            <label class=\"form-label\">");
                EndContext();
                BeginContext(4591, 16, false);
#line 87 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                 Write(L("TenancyName"));

#line default
#line hidden
                EndContext();
                BeginContext(4607, 259, true);
                WriteLiteral(@"</label>
                        </div>
                    </div>
                    <div class=""form-group form-float"">
                        <div class=""form-line"">
                            <input type=""text"" name=""Name"" class=""form-control"" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 4866, "\"", 4899, 1);
#line 92 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
WriteAttributeValue("", 4878, Tenant.MaxNameLength, 4878, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4900, 56, true);
                WriteLiteral(">\n                            <label class=\"form-label\">");
                EndContext();
                BeginContext(4957, 9, false);
#line 93 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                 Write(L("Name"));

#line default
#line hidden
                EndContext();
                BeginContext(4966, 262, true);
                WriteLiteral(@"</label>
                        </div>
                    </div>
                    <div class=""form-group form-float"">
                        <div class=""form-line"">
                            <input type=""text"" name=""ConnectionString"" class=""form-control""");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 5228, "\"", 5280, 1);
#line 98 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
WriteAttributeValue("", 5240, AbpTenantBase.MaxConnectionStringLength, 5240, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5281, 56, true);
                WriteLiteral(">\n                            <label class=\"form-label\">");
                EndContext();
                BeginContext(5338, 29, false);
#line 99 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                 Write(L("DatabaseConnectionString"));

#line default
#line hidden
                EndContext();
                BeginContext(5367, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(5370, 13, false);
#line 99 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                 Write(L("Optional"));

#line default
#line hidden
                EndContext();
                BeginContext(5383, 274, true);
                WriteLiteral(@")</label>
                        </div>
                    </div>
                    <div class=""form-group form-float"">
                        <div class=""form-line"">
                            <input type=""email"" name=""AdminEmailAddress"" class=""form-control"" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 5657, "\"", 5703, 1);
#line 104 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
WriteAttributeValue("", 5669, AbpUserBase.MaxEmailAddressLength, 5669, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5704, 56, true);
                WriteLiteral(">\n                            <label class=\"form-label\">");
                EndContext();
                BeginContext(5761, 22, false);
#line 105 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                 Write(L("AdminEmailAddress"));

#line default
#line hidden
                EndContext();
                BeginContext(5783, 299, true);
                WriteLiteral(@"</label>
                        </div>
                    </div>
                    <div class=""checkbox"">
                        <input type=""checkbox"" name=""IsActive"" value=""true"" id=""CreateTenantIsActive"" class=""filled-in"" checked />
                        <label for=""CreateTenantIsActive"">");
                EndContext();
                BeginContext(6083, 13, false);
#line 110 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                     Write(L("IsActive"));

#line default
#line hidden
                EndContext();
                BeginContext(6096, 59, true);
                WriteLiteral("</label>\n                    </div>\n                    <p>");
                EndContext();
                BeginContext(6156, 74, false);
#line 112 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                  Write(L("DefaultPasswordIs", MyProject.Authorization.Users.User.DefaultPassword));

#line default
#line hidden
                EndContext();
                BeginContext(6230, 171, true);
                WriteLiteral("</p>\n                </div>\n                <div class=\"modal-footer\">\n                    <button type=\"button\" class=\"btn btn-default waves-effect\" data-dismiss=\"modal\">");
                EndContext();
                BeginContext(6402, 11, false);
#line 115 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                                               Write(L("Cancel"));

#line default
#line hidden
                EndContext();
                BeginContext(6413, 89, true);
                WriteLiteral("</button>\n                    <button type=\"submit\" class=\"btn btn-primary waves-effect\">");
                EndContext();
                BeginContext(6503, 9, false);
#line 116 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Tenants\Index.cshtml"
                                                                          Write(L("Save"));

#line default
#line hidden
                EndContext();
                BeginContext(6512, 45, true);
                WriteLiteral("</button>\n                </div>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6564, 288, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""modal fade"" id=""TenantEditModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""TenantEditModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">

        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abp.Application.Services.Dto.PagedResultDto<MyProject.MultiTenancy.Dto.TenantDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
