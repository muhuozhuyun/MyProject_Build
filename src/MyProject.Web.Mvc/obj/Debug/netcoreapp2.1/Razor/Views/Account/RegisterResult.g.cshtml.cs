#pragma checksum "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea2dad40e973fc6ff20e5ecf4cd97bd5ea15f7cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegisterResult), @"mvc.1.0.view", @"/Views/Account/RegisterResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/RegisterResult.cshtml", typeof(AspNetCore.Views_Account_RegisterResult))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea2dad40e973fc6ff20e5ecf4cd97bd5ea15f7cd", @"/Views/Account/RegisterResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b203b3f0805b4f117ac3d0d294f9ef72921dac8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RegisterResult : MyProject.Web.Views.MyProjectRazorPage<MyProject.Web.Models.Account.RegisterResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
  
    ViewBag.Title = L("SuccessfullyRegistered");

#line default
#line hidden
            BeginContext(114, 54, true);
            WriteLiteral("<div class=\"card\">\n    <div class=\"body\">\n        <h4>");
            EndContext();
            BeginContext(169, 27, false);
#line 7 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
       Write(L("SuccessfullyRegistered"));

#line default
#line hidden
            EndContext();
            BeginContext(196, 60, true);
            WriteLiteral("</h4>\n        <ul>\n            <li><span class=\"text-muted\">");
            EndContext();
            BeginContext(257, 16, false);
#line 9 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("NameSurname"));

#line default
#line hidden
            EndContext();
            BeginContext(273, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(283, 20, false);
#line 9 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                              Write(Model.NameAndSurname);

#line default
#line hidden
            EndContext();
            BeginContext(303, 47, true);
            WriteLiteral("</li>\n            <li><span class=\"text-muted\">");
            EndContext();
            BeginContext(351, 16, false);
#line 10 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("TenancyName"));

#line default
#line hidden
            EndContext();
            BeginContext(367, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(377, 17, false);
#line 10 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                              Write(Model.TenancyName);

#line default
#line hidden
            EndContext();
            BeginContext(394, 47, true);
            WriteLiteral("</li>\n            <li><span class=\"text-muted\">");
            EndContext();
            BeginContext(442, 13, false);
#line 11 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("UserName"));

#line default
#line hidden
            EndContext();
            BeginContext(455, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(465, 14, false);
#line 11 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(479, 47, true);
            WriteLiteral("</li>\n            <li><span class=\"text-muted\">");
            EndContext();
            BeginContext(527, 17, false);
#line 12 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                    Write(L("EmailAddress"));

#line default
#line hidden
            EndContext();
            BeginContext(544, 9, true);
            WriteLiteral(":</span> ");
            EndContext();
            BeginContext(554, 18, false);
#line 12 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
                                                               Write(Model.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(572, 34, true);
            WriteLiteral("</li>\n        </ul>\n        <div>\n");
            EndContext();
#line 15 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
             if (!Model.IsActive)
            {

#line default
#line hidden
            BeginContext(654, 83, true);
            WriteLiteral("                <div class=\"alert alert-warning\" role=\"alert\">\n                    ");
            EndContext();
            BeginContext(738, 32, false);
#line 18 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
               Write(L("WaitingForActivationMessage"));

#line default
#line hidden
            EndContext();
            BeginContext(770, 24, true);
            WriteLiteral("\n                </div>\n");
            EndContext();
#line 20 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
            }

#line default
#line hidden
            BeginContext(808, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 22 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
             if (Model.IsEmailConfirmationRequiredForLogin && !Model.IsEmailConfirmed)
            {

#line default
#line hidden
            BeginContext(910, 83, true);
            WriteLiteral("                <div class=\"alert alert-warning\" role=\"alert\">\n                    ");
            EndContext();
            BeginContext(994, 30, false);
#line 25 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
               Write(L("WaitingForEmailActivation"));

#line default
#line hidden
            EndContext();
            BeginContext(1024, 24, true);
            WriteLiteral("\n                </div>\n");
            EndContext();
#line 27 "E:\Demo\MyProject_Build\4.2.1\aspnet-core\src\MyProject.Web.Mvc\Views\Account\RegisterResult.cshtml"
            }

#line default
#line hidden
            BeginContext(1062, 33, true);
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProject.Web.Models.Account.RegisterResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591