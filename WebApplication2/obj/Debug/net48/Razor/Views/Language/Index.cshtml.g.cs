#pragma checksum "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06f390baa520f6d0ddcea828bf502f3635059175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Language_Index), @"mvc.1.0.view", @"/Views/Language/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Language/Index.cshtml", typeof(AspNetCore.Views_Language_Index))]
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
#line 1 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\_ViewImports.cshtml"
using IdentityDemo;

#line default
#line hidden
#line 3 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\_ViewImports.cshtml"
using IdentityDemo.Models;

#line default
#line hidden
#line 4 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\_ViewImports.cshtml"
using IdentityDemo.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\_ViewImports.cshtml"
using IdentityDemo.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f390baa520f6d0ddcea828bf502f3635059175", @"/Views/Language/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2fcbf5d4fd4bbe60b0869ffb5f572c4588b5b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Language_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication2.Models.Language>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 121, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    \r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(265, 48, false);
#line 17 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(313, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 23 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(448, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(509, 47, false);
#line 27 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(556, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 625, "\"", 655, 2);
            WriteAttributeValue("", 632, "/Language/Edit/", 632, 15, true);
#line 30 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Index.cshtml"
WriteAttributeValue("", 647, item.ID, 647, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(656, 36, true);
            WriteLiteral(" >Edit</a> |\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 692, "\"", 724, 2);
            WriteAttributeValue("", 699, "/Language/Delete/", 699, 17, true);
#line 31 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Index.cshtml"
WriteAttributeValue("", 716, item.ID, 716, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(725, 56, true);
            WriteLiteral(" >Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(792, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication2.Models.Language>> Html { get; private set; }
    }
}
#pragma warning restore 1591
