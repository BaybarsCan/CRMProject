#pragma checksum "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Shared\Components\Appointment\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "078b270a99df571924bb7f29403b37b2244d9dfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Appointment_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Appointment/Default.cshtml")]
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
#line 1 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\_ViewImports.cshtml"
using CRMProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\_ViewImports.cshtml"
using CRMProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\_ViewImports.cshtml"
using Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"078b270a99df571924bb7f29403b37b2244d9dfe", @"/Views/Shared/Components/Appointment/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf50f1e0a6bfb237862cff3dab437c7e40ba7ad3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Appointment_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Appointment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<table class=""table table-striped"">
    <thead>
        <tr>
            <th>Appointment Start Date</th>
            <th>Appointment Start Time</th>
            <th>User </th>
            <th>Customer </th>
            <th>Customer Type</th>
            <th>Appointment Status </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Shared\Components\Appointment\Default.cshtml"
         if (Model?.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Shared\Components\Appointment\Default.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Shared\Components\Appointment\Default.cshtml"
                   Write(item?.ScheduledDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Shared\Components\Appointment\Default.cshtml"
                   Write(item?.ScheduledTime.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Shared\Components\Appointment\Default.cshtml"
                   Write(item?.User?.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n");
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 52 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Shared\Components\Appointment\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Shared\Components\Appointment\Default.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td rowspan=\"2\">Size Ait Randevu Bulunmamaktadır</td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Shared\Components\Appointment\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<script>\r\n    function ChangeAppointmentStatus(id,statusId) {\r\n        $.ajax({\r\n                type: \"POST\",\r\n                url: \'");
#nullable restore
#line 68 "C:\Users\deniz\source\repos\CRMProjectClone\CRMProject.sln\CRMProject\Views\Shared\Components\Appointment\Default.cshtml"
                 Write(Url.Action("ChangeAppointmentStatus", "Appointment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                data: {\r\n                    id: id,\r\n                    statusId: statusId\r\n             },\r\n            success: function (data) {\r\n");
            WriteLiteral("                },\r\n                error: function () {\r\n                    toastr.success(\"Randevu İşlemi Gerçekleşirken bir hata oluştur ! \");\r\n                }\r\n            });\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591