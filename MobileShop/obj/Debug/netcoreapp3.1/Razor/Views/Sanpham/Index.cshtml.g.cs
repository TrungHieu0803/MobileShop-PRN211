#pragma checksum "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46cff251401ba6b14ae11d44fe56a4de5d008c47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanpham_Index), @"mvc.1.0.view", @"/Views/Sanpham/Index.cshtml")]
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
#line 1 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46cff251401ba6b14ae11d44fe56a4de5d008c47", @"/Views/Sanpham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<MobileShop.Models.Sanpham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
  
    ViewBag.Title = "Product List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<div class=""row"">
    <div class=""col-md-8"">
        <img class=""img-responsive"" src=""https://cdn.tgdd.vn/2021/11/banner/830-300-830x300-2.png"" />
    </div>
    <div class=""col-md-4"">
        <img src=""https://cdn.tgdd.vn/2021/11/banner/laptopdesk(3)-340x340.jpg"" class=""img-responsive""");
            BeginWriteAttribute("alt", " alt=\"", 460, "\"", 466, 0);
            EndWriteAttribute();
            WriteLiteral(@" />

    </div>
</div>
<div>
    <img class=""img-responsive"" src=""https://cdn.tgdd.vn/2021/10/banner/1200-44-1200x44.png"" />
</div>
<br />
<div class=""row"">
    <div class=""col-lg-3 p-0"">
        <table class=""table table-light table-hover border-bottom-10"">
            <thead>
                <tr>
                    <th class=""text-center navbar-brand bg-secondary"">Danh mục</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td class=""text-center bg-dark"">
                        <a class=""navbar-brand text-warning"" href=""/Sanpham"">Tất cả sản phẩm</a>
                    </td>
                </tr>
");
#nullable restore
#line 36 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                 foreach (var item in ViewBag.Hangsanxuats)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center  bg-dark\">\r\n");
#nullable restore
#line 40 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                               string tenhang = item.Tenhang;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
#nullable restore
#line 41 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                       Write(Html.ActionLink(@tenhang, "Index", "Sanpham", new { Mahang = item.Mahang }, new { @class = "navbar-brand text-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""dt col-lg-9"">
        <div class=""dt col-lg-12"">
            <div class=""row"">
                <h3 style=""text-align: center; background-color: palevioletred; border-radius: 30px; color: whitesmoke""> Danh sách sản phẩm </h3>
");
#nullable restore
#line 53 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div  class=""col-md-4"" style=""padding: 5px;"">
                        <div style=""padding: 5px; border: 1px solid grey; background-color: lavender; border-radius: 20px; height: 450px; margin-bottom: 5px"">
                            <div>
                                <img style=""width: 100%; margin-top: 15px;""");
            BeginWriteAttribute("src", " src=\"", 2443, "\"", 2474, 1);
#nullable restore
#line 58 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 2449, Url.Content(item.Anhbia), 2449, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <div class=\"p-4\">\r\n                                    <div class=\"text-center\">\r\n                                        <h4><a style=\"font-size:20px; color:black; text-align: center\"");
            BeginWriteAttribute("href", " href=\"", 2696, "\"", 2729, 2);
            WriteAttributeValue("", 2703, "/Sanpham/Detail/", 2703, 16, true);
#nullable restore
#line 61 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 2719, item.Masp, 2719, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                                                                                                                                    Write(item.Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                        <span>Giá: ");
#nullable restore
#line 62 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                                              Write(item.Giatien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"card-footer p-4 pt-0 border-top-0 bg-transparent\">\r\n                                    <div class=\"text-center\">\r\n");
#nullable restore
#line 67 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                                         using (Html.BeginForm("ThemGioHang", "GioHang", new { @iMasp = item.Masp, @strURL = Request.Url.ToString() }))
                                        {
                                            if (item.Soluong < 1)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <button disabled class=""btn btn-outline-dark text-dark"">
                                                    <i class=""bi-cart-fill me-1""></i>Hết hàng
                                                </button>
");
#nullable restore
#line 74 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <input class=\"btn btn-danger\" type=\"submit\" value=\"Mua hàng\" id=\"bgnGioHang\" />\r\n");
#nullable restore
#line 78 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 85 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"text-center\" style=\"margin-top:20px\">\r\n                Trang ");
#nullable restore
#line 88 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                  Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 88 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                                                                              Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 89 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
           Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<MobileShop.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
