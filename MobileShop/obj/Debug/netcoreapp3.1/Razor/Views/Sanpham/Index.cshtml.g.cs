#pragma checksum "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df397c91e3242fd845c8222924dd978ace0e8755"
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
#line 1 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df397c91e3242fd845c8222924dd978ace0e8755", @"/Views/Sanpham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sanpham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
  
    ViewBag.Title = "List Product";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 class=""mt-2"" style=""text-align:center"">Danh Sách sản phẩm</h2>

<table class=""table table-bordered"">
    <tr>
        <th>Mã sản phẩm</th>
        <th>Tên sản phẩm</th>
        <th>Giá tiền</th>
        <th>Số lượng</th>
        <th>Mô tả</th>
        <th>Thẻ sim</th>
        <th>Bộ nhớ trong</th>
        <th>Sản phẩm mới</th>
        <th>Ram</th>
        <th>Ảnh bìa</th>
        <th>Mua hàng</th>
    </tr>
");
#nullable restore
#line 23 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
           Write(item.Masp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
           Write(item.Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
           Write(item.Giatien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
           Write(item.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
           Write(item.Mota);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
           Write(item.Thesim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
           Write(item.Bonhotrong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 33 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
             if (item.Sanphammoi == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Hàng mới về</td>\r\n");
#nullable restore
#line 36 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Hàng cũ</td>\r\n");
#nullable restore
#line 40 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 41 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
           Write(item.Ram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1140, "\"", 1171, 1);
#nullable restore
#line 43 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 1146, Url.Content(item.Anhbia), 1146, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" />\r\n            </td>\r\n            <td>\r\n                <button>Mua hàng</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n\r\n<section class=\"product-area li-laptop-product li-laptop-product-2 pb-45\">\r\n    <div class=\"container\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 56 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <!-- single-product-wrap start -->\r\n                            <div class=\"single-product-wrap\">\r\n                                <div class=\"product-image\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1788, "\"", 1821, 2);
            WriteAttributeValue("", 1795, "/Sanpham/Detail/", 1795, 16, true);
#nullable restore
#line 61 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 1811, item.Masp, 1811, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1869, "\"", 1900, 1);
#nullable restore
#line 62 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 1875, Url.Content(item.Anhbia), 1875, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""50"" height=""50"" />
                                    </a>
                                </div>
                                <div class=""product_desc"">
                                    <div class=""product_desc_info"">
                                        <div class=""product-review"">
                                            <h5 class=""manufacturer"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 2331, "\"", 2364, 2);
            WriteAttributeValue("", 2338, "/Sanpham/Detail/", 2338, 16, true);
#nullable restore
#line 69 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
WriteAttributeValue("", 2354, item.Masp, 2354, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                                                                                Write(item.Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </h5>\r\n                                        </div>\r\n                                        <h4><a class=\"product_name\">");
#nullable restore
#line 72 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                                                               Write(item.Mota);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                        <div class=\"price-box\">\r\n                                            <span class=\"new-price\">");
#nullable restore
#line 74 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                                                               Write(item.Giatien);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                    </div>
                                    <div class=""add-actions"">
                                        <ul class=""add-actions-link"">
                                            <li class=""add-cart active""><a href=""#"">Add to cart</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 84 "C:\Users\admin\Desktop\New folder (3)\MobileShop-PRN211\MobileShop\Views\Sanpham\Index.cshtml"
                        }                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n     </div>\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
