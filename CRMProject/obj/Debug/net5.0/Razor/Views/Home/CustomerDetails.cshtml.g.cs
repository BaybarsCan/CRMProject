#pragma checksum "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bf99e92667f3be18f55b227cdc1364206f840a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerDetails), @"mvc.1.0.view", @"/Views/Home/CustomerDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bf99e92667f3be18f55b227cdc1364206f840a2", @"/Views/Home/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf50f1e0a6bfb237862cff3dab437c7e40ba7ad3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerUserModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
  
    ViewData["Title"] = "CustomerDetails";
    ViewData["SessionUser"] = Model.AccountUser.Username;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
<script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>

<h1>CustomerDetails</h1>

<tr>
    <td>
        <div class=""form-group"">
            <label>Name & Surname</label>
            <input type=""text"" class=""form-control"" id=""userName""");
            BeginWriteAttribute("value", " value=", 1176, "", 1208, 1);
#nullable restore
#line 20 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
WriteAttributeValue("", 1183, Model.Customer.FirstName, 1183, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </td>\r\n    <td>\r\n        <div class=\"form-group\">\r\n            <label>Email</label>\r\n            <input type=\"email\" class=\"form-control\" id=\"email\"");
            BeginWriteAttribute("value", " value=", 1379, "", 1407, 1);
#nullable restore
#line 26 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
WriteAttributeValue("", 1386, Model.Customer.Email, 1386, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </td>\r\n    <td>\r\n        <div class=\"form-group\">\r\n            <label>Job Title</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"title\"");
            BeginWriteAttribute("value", " value=", 1581, "", 1612, 1);
#nullable restore
#line 32 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
WriteAttributeValue("", 1588, Model.Customer.JobTitle, 1588, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </td>\r\n    <td>\r\n        <div class=\"form-group\">\r\n            <label>City</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"city\"");
            BeginWriteAttribute("value", " value=", 1780, "", 1807, 1);
#nullable restore
#line 38 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
WriteAttributeValue("", 1787, Model.Customer.City, 1787, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </td>\r\n    <td>\r\n        <div class=\"form-group\">\r\n            <label>Company Name</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"companyName\"");
            BeginWriteAttribute("value", " value=", 1990, "", 2024, 1);
#nullable restore
#line 44 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
WriteAttributeValue("", 1997, Model.Customer.CompanyName, 1997, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </td>\r\n    <td>\r\n        <div class=\"form-group\">\r\n            <label>Related Employee</label>\r\n            <select class=\"form-control\" id=\"customerUserID\" onchange=\"SelectWasChanged()\">\r\n");
#nullable restore
#line 51 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
                 foreach (var user in Model.UserList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bf99e92667f3be18f55b227cdc1364206f840a28079", async() => {
#nullable restore
#line 53 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
                                                Write(Model.User.Username);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bf99e92667f3be18f55b227cdc1364206f840a210211", async() => {
#nullable restore
#line 54 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
                                        Write(user.Username);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
                       WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n    </td>\r\n    <td>\r\n        <button type=\"submit\"\r\n                class=\"btn btn-primary btn-sm\"\r\n                onclick=changeCustomersInfos()>\r\n            Update\r\n        </button>\r\n    </td>\r\n</tr>\r\n\r\n");
            WriteLiteral("\r\n\r\n<script>\r\n    var customerUserID = \"\";\r\n\r\n    function SelectWasChanged() {\r\n        customerUserID = $(\'#customerUserID\').val();\r\n        console.log($(\'#customerUserID\').val());\r\n    }\r\n\r\n    function changeCustomersInfos(id = ");
#nullable restore
#line 84 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
                                  Write(Model.Customer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(", userId = ");
#nullable restore
#line 84 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
                                                               Write(Model.Customer.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@") {
        var id = id;
        var userName = $('#userName').val();
        var email = $('#email').val();
        var title = $('#title').val();
        var city = $('#city').val();
        var companyName = $('#companyName').val();

        if (customerUserID == """") {
            customerUserID = userId;
        }

            $.ajax({
            url: '");
#nullable restore
#line 97 "C:\Users\KaanB\Source\Repos\GitHubCrmProjectClone\CRMProject\CRMProject\Views\Home\CustomerDetails.cshtml"
             Write(Url.Action("CustomerDetails", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: {
                    City: city,
                    CompanyName: companyName,
                    Email: email,
                    FirstName: userName,
                    Id: id,
                    JobTitle: title,
                    User: """",
                    UserId: customerUserID
            },
            method: ""POST"",
            success: (response) => {
                if (response==true) {
                    window.location.href = ""/Home/GetCustomer"";
                }
            },
            error: (xhr) => {
                console.log(xhr);
            }
        })
    }
</script>



");
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
