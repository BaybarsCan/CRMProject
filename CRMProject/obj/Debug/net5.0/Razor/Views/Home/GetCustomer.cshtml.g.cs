#pragma checksum "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd8ea00dd6c8f1c50c935e70ca3f5bb04165969d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetCustomer), @"mvc.1.0.view", @"/Views/Home/GetCustomer.cshtml")]
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
#nullable restore
#line 1 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\_ViewImports.cshtml"
using CRMProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\_ViewImports.cshtml"
using CRMProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\_ViewImports.cshtml"
using Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd8ea00dd6c8f1c50c935e70ca3f5bb04165969d", @"/Views/Home/GetCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf50f1e0a6bfb237862cff3dab437c7e40ba7ad3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerUserModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
  
    ViewData["Title"] = "GetCustomer";
    ViewData["SessionUser"] = Model.User.Username;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
<script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>

<table class=""table table-borderless table-hover"">
    <thead>
        <tr>
            <th>#</th>
            <th>Name</th>
            <th>Email</th>
            <th>Title</th>
            <th>City</th>
      ");
            WriteLiteral("      <th>Company</th>\r\n            <th>Personel</th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 26 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
     foreach (var item in Model.CustomerList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
               Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
               Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
               Write(item.User.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1698, "\"", 1738, 2);
            WriteAttributeValue("", 1705, "/Home/CustomerDetails?id=", 1705, 25, true);
#nullable restore
#line 38 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
WriteAttributeValue("", 1730, item.Id, 1730, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Details</a>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n");
#nullable restore
#line 42 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\GetCustomer.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerUserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
