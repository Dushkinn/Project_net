#pragma checksum "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookType\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48cc1af36cc8cff96fb7c0a83b552bfd8e97d4ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookType_Details), @"mvc.1.0.view", @"/Views/BookType/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookType/Details.cshtml", typeof(AspNetCore.Views_BookType_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48cc1af36cc8cff96fb7c0a83b552bfd8e97d4ce", @"/Views/BookType/Details.cshtml")]
    public class Views_BookType_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.Language>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookType\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Language</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(257, 48, false);
#line 16 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookType\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(305, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(349, 44, false);
#line 19 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookType\Details.cshtml"
       Write(Html.DisplayFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(393, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 460, "\"", 484, 1);
#line 24 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\BookType\Details.cshtml"
WriteAttributeValue("", 475, Model.ID, 475, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(485, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-page=\"./Index\">Back to List</a>\r\n</div>\r\n");
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
