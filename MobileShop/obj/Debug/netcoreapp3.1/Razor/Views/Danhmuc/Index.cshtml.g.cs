#pragma checksum "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Danhmuc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b118f2a591f16f8f187e8041f7c89968b4f7c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Danhmuc_Index), @"mvc.1.0.view", @"/Views/Danhmuc/Index.cshtml")]
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
#line 2 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Danhmuc\Index.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b118f2a591f16f8f187e8041f7c89968b4f7c5", @"/Views/Danhmuc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Danhmuc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hangsanxuat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Danhmuc\Index.cshtml"
   
    Layout = "~/Views/Shared/_LayoutHomepage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"bg-success\">\r\n\r\n    <h3> DANH MỤC  </h3>\r\n\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 15 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Danhmuc\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"nav nav-pills\" role=\"tablist\">\r\n            <li role=\"presentation\" class=\"active\"><a href=\"#home\" aria-controls=\"home\" role=\"tab\" data-toggle=\"tab\">");
#nullable restore
#line 18 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Danhmuc\Index.cshtml"
                                                                                                                Write(item.Tenhang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n            \r\n        </ul>");
#nullable restore
#line 20 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Danhmuc\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hangsanxuat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
