#pragma checksum "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "279b3f0c0f05ee89edb517f3c6ca004604f5a302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NguoidungIndex), @"mvc.1.0.view", @"/Views/Admin/NguoidungIndex.cshtml")]
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
#line 1 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279b3f0c0f05ee89edb517f3c6ca004604f5a302", @"/Views/Admin/NguoidungIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_NguoidungIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MobileShop.Models.Nguoidung>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
  

    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 class=""mt-2"" style=""text-align:center"">Quản lý người dùng</h2>
<table class=""table table-bordered"">
    <tr>
        <th>Họ Tên</th>
        <th>Email</th>
        <th>Điện thoại</th>
        <th>Mật khẩu</th>
        <th>Địa chỉ </th>
        <th>Tên quyền </th>
        <th>Hành động</th>
    </tr>
");
#nullable restore
#line 18 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 22 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hoten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dienthoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Matkhau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Diachi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdquyenNavigation.TenQuyen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1162, "\"", 1207, 2);
            WriteAttributeValue("", 1169, "/Admin/EditNguoidung/", 1169, 21, true);
#nullable restore
#line 40 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
WriteAttributeValue("", 1190, item.MaNguoiDung, 1190, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\nTrang ");
#nullable restore
#line 46 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
  Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 46 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
                                                              Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\NguoidungIndex.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<MobileShop.Models.Nguoidung>> Html { get; private set; }
    }
}
#pragma warning restore 1591
