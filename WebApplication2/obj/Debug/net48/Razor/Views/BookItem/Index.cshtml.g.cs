#pragma checksum "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2bf2106718019f9356b0c7ac492069f4d47acc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookItem_Index), @"mvc.1.0.view", @"/Views/BookItem/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookItem/Index.cshtml", typeof(AspNetCore.Views_BookItem_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2bf2106718019f9356b0c7ac492069f4d47acc0", @"/Views/BookItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2fcbf5d4fd4bbe60b0869ffb5f572c4588b5b6", @"/Views/_ViewImports.cshtml")]
    public class Views_BookItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication2.Models.BookItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookItem\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 155, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(299, 45, false);
#line 17 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookItem\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book.Name));

#line default
#line hidden
            EndContext();
            BeginContext(344, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(400, 51, false);
#line 20 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookItem\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State.StateName));

#line default
#line hidden
            EndContext();
            BeginContext(451, 90, true);
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookItem\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(590, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(651, 44, false);
#line 32 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookItem\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Book.Name));

#line default
#line hidden
            EndContext();
            BeginContext(695, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(763, 50, false);
#line 35 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookItem\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.State.StateName));

#line default
#line hidden
            EndContext();
            BeginContext(813, 73, true);
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 886, "\"", 916, 2);
            WriteAttributeValue("", 893, "/BookItem/Edit/", 893, 15, true);
#line 40 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookItem\Index.cshtml"
WriteAttributeValue("", 908, item.ID, 908, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(917, 35, true);
            WriteLiteral(">Edit</a> |\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 952, "\"", 984, 2);
            WriteAttributeValue("", 959, "/BookItem/Delete/", 959, 17, true);
#line 41 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookItem\Index.cshtml"
WriteAttributeValue("", 976, item.ID, 976, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(985, 55, true);
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 44 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookItem\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1051, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication2.Models.BookItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
