#pragma checksum "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99cdd10d8b421084f1a03307e617a8982ac6106b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Language_Delete), @"mvc.1.0.view", @"/Views/Language/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Language/Delete.cshtml", typeof(AspNetCore.Views_Language_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99cdd10d8b421084f1a03307e617a8982ac6106b", @"/Views/Language/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb2fcbf5d4fd4bbe60b0869ffb5f572c4588b5b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Language_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.Language>
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Language</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(303, 48, false);
#line 17 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(351, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(395, 44, false);
#line 20 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LanguageName));

#line default
#line hidden
            EndContext();
            BeginContext(439, 30, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Delete.cshtml"
     using (Html.BeginForm("DeleteLanguage" , "Language"))
    {
        

#line default
#line hidden
            BeginContext(545, 23, false);
#line 26 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(581, 33, false);
#line 28 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Delete.cshtml"
   Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(624, 85, true);
            WriteLiteral("        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> \r\n            ");
            EndContext();
            BeginContext(709, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa3a50db1d6546f9aee9cfb89c7fd1bb", async() => {
                BeginContext(731, 12, true);
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
            BeginContext(747, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\Language\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(756, 8, true);
            WriteLiteral("</div>\r\n");
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
