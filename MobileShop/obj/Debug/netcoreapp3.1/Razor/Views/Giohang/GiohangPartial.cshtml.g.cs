#pragma checksum "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Giohang\GiohangPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "809a1ada6f92e325299762d801ec29ee8b3a47c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Giohang_GiohangPartial), @"mvc.1.0.view", @"/Views/Giohang/GiohangPartial.cshtml")]
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
#line 1 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"809a1ada6f92e325299762d801ec29ee8b3a47c8", @"/Views/Giohang/GiohangPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Giohang_GiohangPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style type=\"text/css\">\r\n    .giohang {\r\n        color: white;\r\n        font-size: large\r\n    }\r\n</style>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 111, "\"", 150, 1);
#nullable restore
#line 8 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Giohang\GiohangPartial.cshtml"
WriteAttributeValue("", 118, Url.Action("GioHang","GioHang"), 118, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"giohang\">\r\n    Giỏ hàng<i class=\"fa fa-shopping-cart\">\r\n    </i> (");
#nullable restore
#line 10 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Giohang\GiohangPartial.cshtml"
     Write(ViewBag.TongSoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
