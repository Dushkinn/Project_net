#pragma checksum "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17a1aa8ba822dc0a8948224129803706ff6faf5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Edit), @"mvc.1.0.view", @"/Views/Book/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Edit.cshtml", typeof(AspNetCore.Views_Book_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17a1aa8ba822dc0a8948224129803706ff6faf5c", @"/Views/Book/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2fcbf5d4fd4bbe60b0869ffb5f572c4588b5b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.ViewModel.BookViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 91, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Author</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 15 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(296, 23, false);
#line 17 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(338, 89, false);
#line 20 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
       Write(Html.ValidationSummary(true, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(442, 33, false);
#line 21 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
       Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(477, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(532, 84, false);
#line 23 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(616, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(635, 93, false);
#line 24 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(728, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(747, 107, false);
#line 25 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(854, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(931, 91, false);
#line 28 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.LabelFor(model => model.Discription, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1041, 100, false);
#line 29 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.EditorFor(model => model.Discription, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1160, 114, false);
#line 30 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Discription, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1274, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1351, 96, false);
#line 33 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.LabelFor(model => model.selectedLanguage, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1466, 73, false);
#line 34 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.DropDownList("selectedLanguage", (MultiSelectList)ViewBag.Languages));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1558, 119, false);
#line 35 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.selectedLanguage, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1754, 96, false);
#line 38 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.LabelFor(model => model.selectedBookType, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1850, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1869, 73, false);
#line 39 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.DropDownList("selectedBookType", (MultiSelectList)ViewBag.BookTypes));

#line default
#line hidden
            EndContext();
            BeginContext(1942, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1961, 119, false);
#line 40 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.selectedBookType, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2080, 160, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-default\" />\r\n            </div>\r\n");
            EndContext();
#line 45 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Book\Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(2251, 33, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2284, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9bd246a0b6046fc8fe1ace325597b18", async() => {
                BeginContext(2306, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2322, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
