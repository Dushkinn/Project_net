#pragma checksum "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/ReservationBook/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "396da6af771ade07645d91db152cbb57b94da930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReservationBook_Details), @"mvc.1.0.view", @"/Views/ReservationBook/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReservationBook/Details.cshtml", typeof(AspNetCore.Views_ReservationBook_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"396da6af771ade07645d91db152cbb57b94da930", @"/Views/ReservationBook/Details.cshtml")]
    public class Views_ReservationBook_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.Language>
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
#line 4 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/ReservationBook/Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 122, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Reservation Book</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(250, 48, false);
#line 16 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/ReservationBook/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(298, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(339, 44, false);
#line 19 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/ReservationBook/Details.cshtml"
       Write(Html.DisplayFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(383, 62, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 445, "\"", 469, 1);
#line 24 "/Users/nikitadushkin/Projects/Project_net/WebApplication2/Views/ReservationBook/Details.cshtml"
WriteAttributeValue("", 460, Model.ID, 460, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(470, 62, true);
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
