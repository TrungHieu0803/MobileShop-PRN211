#pragma checksum "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c779a9777bc75720f0d50c1e688ff6d801e7dd45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DonhangIndex), @"mvc.1.0.view", @"/Views/Admin/DonhangIndex.cshtml")]
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
#nullable restore
#line 2 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c779a9777bc75720f0d50c1e688ff6d801e7dd45", @"/Views/Admin/DonhangIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DonhangIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MobileShop.Models.Donhang>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
  
    ViewBag.Title = "DonhangIndex";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 class=""mt-2"" style=""text-align:center"">Quản lý đơn hàng</h2>
<table class=""table table-bordered"">
    <tr>
        <th>Mã đơn</th>
        <th>Ngày đặt</th>
        <th>Tình trạng</th>
        <th>Mã người dùng</th>
        <th>Số lượng sản phẩm</th>
        <th>Tổng tiền</th>
        <th>Chi tiết</th>
    </tr>
");
#nullable restore
#line 18 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
           Write(item.Madon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
           Write(item.Ngaydat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 23 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
             switch (item.Tinhtrang)
            {
                case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Hoàn thành</td>\r\n");
#nullable restore
#line 27 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
                    break;
                case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Đã hủy</td>\r\n");
#nullable restore
#line 30 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
                    break;
                default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Đang xử lý</td>\r\n");
#nullable restore
#line 33 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
                    break;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>");
#nullable restore
#line 36 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
           Write(item.MaNguoidung);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
              
                int soluong = 0;
                int tongtien = 0;
                foreach (var chitiet in ViewBag.Chitietdonhangs)
                {
                    if (chitiet.Madon == item.Madon)
                    {
                        soluong += chitiet.Soluong;
                        tongtien += chitiet.Thanhtien;
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 48 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
               Write(soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 49 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
               Write(tongtien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1569, "\"", 1606, 2);
            WriteAttributeValue("", 1576, "/Admin/EditDonhang/", 1576, 19, true);
#nullable restore
#line 52 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
WriteAttributeValue("", 1595, item.Madon, 1595, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xem</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\nTrang ");
#nullable restore
#line 58 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
  Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 58 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
                                                              Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\ADMIN\Desktop\MobileShop-PRN211\MobileShop\Views\Admin\DonhangIndex.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<MobileShop.Models.Donhang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
