#pragma checksum "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32ee68804377979bea08a3f8e432081fa37766cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Create.cshtml", typeof(AspNetCore.Views_User_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ee68804377979bea08a3f8e432081fa37766cd", @"/Views/User/Create.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.ViewModel.UserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(59, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 133, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n<h4>Book</h4>\r\n<hr />\r\n\r\n\r\n<div class=\"form-group\">\r\n\r\n\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 23 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(344, 23, false);
#line 25 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(386, 89, false);
#line 28 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
       Write(Html.ValidationSummary(true, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(490, 33, false);
#line 29 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
       Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(525, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(580, 88, false);
#line 31 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
           Write(Html.LabelFor(model => model.FullName, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(668, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(687, 97, false);
#line 32 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
           Write(Html.EditorFor(model => model.FullName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(784, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(803, 111, false);
#line 33 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.FullName, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(914, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(991, 88, false);
#line 36 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
           Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1098, 97, false);
#line 37 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
           Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1214, 111, false);
#line 38 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Password, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1402, 92, false);
#line 41 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
           Write(Html.LabelFor(model => model.selectedRole, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1513, 65, false);
#line 42 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
           Write(Html.DropDownList("selectedRole", (MultiSelectList)ViewBag.Roles));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1597, 115, false);
#line 43 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.selectedRole, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1712, 160, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n");
            EndContext();
#line 48 "C:\Users\duski\Source\Repos\Project_net2\WebApplication2\Views\User\Create.cshtml"
        }

#line default
#line hidden
            BeginContext(1883, 39, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.ViewModel.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
