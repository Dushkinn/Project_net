#pragma checksum "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\StateType\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea889c2453bf36867ad160dace2c5f5c340f420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StateType_Edit), @"mvc.1.0.view", @"/Views/StateType/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StateType/Edit.cshtml", typeof(AspNetCore.Views_StateType_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea889c2453bf36867ad160dace2c5f5c340f420", @"/Views/StateType/Edit.cshtml")]
    public class Views_StateType_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.StateType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\StateType\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 91, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Author</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 15 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\StateType\Edit.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(282, 23, false);
#line 17 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\StateType\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(324, 89, false);
#line 20 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\StateType\Edit.cshtml"
       Write(Html.ValidationSummary(true, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(428, 33, false);
#line 21 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\StateType\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(463, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(518, 89, false);
#line 23 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\StateType\Edit.cshtml"
           Write(Html.LabelFor(model => model.StateName, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(607, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(626, 98, false);
#line 24 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\StateType\Edit.cshtml"
           Write(Html.EditorFor(model => model.StateName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(724, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(743, 112, false);
#line 25 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\StateType\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.StateName, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(855, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(888, 138, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-default\" />\r\n            </div>\r\n");
            EndContext();
#line 31 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\StateType\Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(1037, 83, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-page=\"./Index\">Back to List</a>\r\n</div>\r\n\r\n");
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
