#pragma checksum "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e4bf79b13e75d026ebb2bd7e83dff3948aaf082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\_ViewImports.cshtml"
using DataTransferPart2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\_ViewImports.cshtml"
using DataTransferPart2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e4bf79b13e75d026ebb2bd7e83dff3948aaf082", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321ec7a54278bb203255479ab0e1b15d5a9829ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n\r\n<p>Student Name: ");
#nullable restore
#line 10 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
            Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Student LastName: ");
#nullable restore
#line 11 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
                Write(ViewData["LastName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Student Age: ");
#nullable restore
#line 12 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
           Write(TempData["Age"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>




<div class=""container"">
        <div class=""row"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Count</th>
                        <th scope=""col"">Id</th>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Age</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 29 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
                     foreach (var item in  Model.Students)
                    {
                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 33 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
                           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 45 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
 foreach (var item in Model.arr)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 47 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
  Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "C:\Users\rasul\OneDrive\Masaüstü\DataTransferPart2\DataTransferPart2\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591