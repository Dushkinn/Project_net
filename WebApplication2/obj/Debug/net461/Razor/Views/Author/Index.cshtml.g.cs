#pragma checksum "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f25ccf85603b8d1f631874da349e176bc1604eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Index), @"mvc.1.0.view", @"/Views/Author/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Author/Index.cshtml", typeof(AspNetCore.Views_Author_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f25ccf85603b8d1f631874da349e176bc1604eb", @"/Views/Author/Index.cshtml")]
    public class Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication2.Models.Author>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 156, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(298, 44, false);
#line 17 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(342, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(398, 45, false);
#line 20 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Biography));

#line default
#line hidden
            EndContext();
            BeginContext(443, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(499, 39, false);
#line 23 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(538, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(673, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(722, 43, false);
#line 33 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(765, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(821, 44, false);
#line 36 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Biography));

#line default
#line hidden
            EndContext();
            BeginContext(865, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(921, 38, false);
#line 39 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DOB));

#line default
#line hidden
            EndContext();
            BeginContext(959, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1016, "\"", 1044, 2);
            WriteAttributeValue("", 1023, "/Author/Edit/", 1023, 13, true);
#line 42 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
WriteAttributeValue("", 1036, item.Id, 1036, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1045, 31, true);
            WriteLiteral(">Edit</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1076, "\"", 1106, 2);
            WriteAttributeValue("", 1083, "/Author/Delete/", 1083, 15, true);
#line 43 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
WriteAttributeValue("", 1098, item.Id, 1098, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1107, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Author\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1165, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication2.Models.Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
