#pragma checksum "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb963ed7fd1f28e1990ea4b5cd53740af7cb5c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Create), @"mvc.1.0.view", @"/Views/Book/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Create.cshtml", typeof(AspNetCore.Views_Book_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb963ed7fd1f28e1990ea4b5cd53740af7cb5c9", @"/Views/Book/Create.cshtml")]
    public class Views_Book_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.ViewModel.BookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(57, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 133, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n<h4>Book</h4>\r\n<hr />\r\n\r\n\r\n<div class=\"form-group\">\r\n\r\n\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 22 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(342, 23, false);
#line 24 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(384, 89, false);
#line 27 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
       Write(Html.ValidationSummary(true, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(488, 33, false);
#line 28 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
       Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(523, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(578, 84, false);
#line 30 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(662, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(681, 93, false);
#line 31 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(774, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(793, 107, false);
#line 32 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(900, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(977, 91, false);
#line 35 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.LabelFor(model => model.Discription, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1087, 100, false);
#line 36 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.EditorFor(model => model.Discription, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1206, 114, false);
#line 37 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Discription, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1397, 96, false);
#line 40 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.LabelFor(model => model.selectedLanguage, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1512, 73, false);
#line 41 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.DropDownList("selectedLanguage", (MultiSelectList)ViewBag.Languages));

#line default
#line hidden
            EndContext();
            BeginContext(1585, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1604, 119, false);
#line 42 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.selectedLanguage, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1800, 96, false);
#line 45 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.LabelFor(model => model.selectedBookType, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1915, 73, false);
#line 46 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.DropDownList("selectedBookType", (MultiSelectList)ViewBag.BookTypes));

#line default
#line hidden
            EndContext();
            BeginContext(1988, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2007, 119, false);
#line 47 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.selectedBookType, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 160, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n");
            EndContext();
#line 52 "C:\Users\duski\source\repos\WebApplication2\WebApplication2\Views\Book\Create.cshtml"
        }

#line default
#line hidden
            BeginContext(2297, 47, true);
            WriteLiteral("    </div>\r\n        </div>\r\n\r\n<div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.ViewModel.BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
