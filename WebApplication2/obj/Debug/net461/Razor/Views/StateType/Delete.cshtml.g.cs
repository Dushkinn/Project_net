#pragma checksum "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/StateType/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "224277ac55f9c7e04492a508b3afd5758d0b54b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StateType_Delete), @"mvc.1.0.view", @"/Views/StateType/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StateType/Delete.cshtml", typeof(AspNetCore.Views_StateType_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224277ac55f9c7e04492a508b3afd5758d0b54b2", @"/Views/StateType/Delete.cshtml")]
    public class Views_StateType_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.StateType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(41, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/StateType/Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 161, true);
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>StateType</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(289, 45, false);
#line 17 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/StateType/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StateName));

#line default
#line hidden
            EndContext();
            BeginContext(334, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(375, 41, false);
#line 20 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/StateType/Delete.cshtml"
       Write(Html.DisplayFor(model => model.StateName));

#line default
#line hidden
            EndContext();
            BeginContext(416, 26, true);
            WriteLiteral("\n        </dd>\n    </dl>\n\n");
            EndContext();
#line 24 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/StateType/Delete.cshtml"
     using (Html.BeginForm("DeleteStateType" , "StateType"))
    {
        

#line default
#line hidden
            BeginContext(518, 23, false);
#line 26 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/StateType/Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(552, 33, false);
#line 28 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/StateType/Delete.cshtml"
   Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(593, 123, true);
            WriteLiteral("        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> \n            <a asp-page=\"./Index\">Back to List</a>\n");
            EndContext();
#line 32 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/StateType/Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(722, 7, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.StateType> Html { get; private set; }
    }
}
#pragma warning restore 1591
