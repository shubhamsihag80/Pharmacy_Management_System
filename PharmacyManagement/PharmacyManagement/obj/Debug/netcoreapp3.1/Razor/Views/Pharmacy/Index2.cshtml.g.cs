#pragma checksum "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\Pharmacy\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d599b357cc4a4daaa88625cfa4c0b6ac085654e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pharmacy_Index2), @"mvc.1.0.view", @"/Views/Pharmacy/Index2.cshtml")]
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
#line 1 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\_ViewImports.cshtml"
using PharmacyManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\_ViewImports.cshtml"
using PharmacyManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d599b357cc4a4daaa88625cfa4c0b6ac085654e1", @"/Views/Pharmacy/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1eff945a4fac666bdf353a10598f75b570f6289", @"/Views/_ViewImports.cshtml")]
    public class Views_Pharmacy_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PharmacyManagement.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\Pharmacy\Index2.cshtml"
  
    ViewData["Title"] = "Index2";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Customer Details</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\Pharmacy\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\Pharmacy\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\Pharmacy\Index2.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\Pharmacy\Index2.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\Pharmacy\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\Pharmacy\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\Pharmacy\Index2.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\lenovo\source\repos\PharmacyManagement\PharmacyManagement\Views\Pharmacy\Index2.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PharmacyManagement.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
