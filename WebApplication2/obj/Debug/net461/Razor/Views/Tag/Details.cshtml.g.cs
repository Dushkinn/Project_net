#pragma checksum "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/Tag/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2709e2d2a9556563a775a5326ccd917a09f3dd33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tag_Details), @"mvc.1.0.view", @"/Views/Tag/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tag/Details.cshtml", typeof(AspNetCore.Views_Tag_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2709e2d2a9556563a775a5326ccd917a09f3dd33", @"/Views/Tag/Details.cshtml")]
    public class Views_Tag_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.Language>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(40, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/Tag/Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 114, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Language</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(242, 48, false);
#line 16 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/Tag/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(290, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(331, 44, false);
#line 19 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/Tag/Details.cshtml"
       Write(Html.DisplayFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(375, 62, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 437, "\"", 461, 1);
#line 24 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/Tag/Details.cshtml"
WriteAttributeValue("", 452, Model.ID, 452, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(462, 62, true);
            WriteLiteral(">Edit</a> |\n    <a asp-page=\"./Index\">Back to List</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.Language> Html { get; private set; }
    }
}
#pragma warning restore 1591
