#pragma checksum "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e87cff27d87b1b7040de6a675f358ef2eeff203"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_HangsanxuatIndex), @"mvc.1.0.view", @"/Views/Admin/HangsanxuatIndex.cshtml")]
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
#line 1 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e87cff27d87b1b7040de6a675f358ef2eeff203", @"/Views/Admin/HangsanxuatIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_HangsanxuatIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MobileShop.Models.Hangsanxuat>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml"
  
    ViewBag.Title = "HangsanxuatIndex";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 class=""mt-2"" style=""text-align:center"">Qu???n l?? h??ng s???n xu???t</h2>
<p>
    <a href=""/Admin/AddHang""><button class=""btn btn-success"">Th??m h??ng m????i</button></a>
</p>
<table class=""table table-bordered"">
    <tr>
        <th>Ma?? h??ng</th>
        <th>T??n h??ng</th>       
        <th></th>
    </tr>
");
#nullable restore
#line 17 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml"
           Write(item.Mahang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml"
           Write(item.Tenhang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 679, "\"", 714, 2);
            WriteAttributeValue("", 686, "/Admin/EditHang/", 686, 16, true);
#nullable restore
#line 24 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml"
WriteAttributeValue("", 702, item.Mahang, 702, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">S????a</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\nTrang ");
#nullable restore
#line 30 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml"
  Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 30 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml"
                                                              Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 31 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\HangsanxuatIndex.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<MobileShop.Models.Hangsanxuat>> Html { get; private set; }
    }
}
#pragma warning restore 1591
