#pragma checksum "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/User/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4addd0e21298fa8c07b0e3e8a2609a54372d8239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Delete), @"mvc.1.0.view", @"/Views/User/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Delete.cshtml", typeof(AspNetCore.Views_User_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4addd0e21298fa8c07b0e3e8a2609a54372d8239", @"/Views/User/Delete.cshtml")]
    public class Views_User_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(36, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/User/Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(122, 160, true);
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Language</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(283, 44, false);
#line 17 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/User/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(327, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(368, 40, false);
#line 20 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/User/Delete.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(408, 26, true);
            WriteLiteral("\n        </dd>\n    </dl>\n\n");
            EndContext();
#line 24 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/User/Delete.cshtml"
     using (Html.BeginForm("DeleteUser" , "User"))
    {
        

#line default
#line hidden
            BeginContext(500, 23, false);
#line 26 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/User/Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(534, 33, false);
#line 28 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/User/Delete.cshtml"
   Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(575, 123, true);
            WriteLiteral("        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> \n            <a asp-page=\"./Index\">Back to List</a>\n");
            EndContext();
#line 32 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/User/Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(704, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
