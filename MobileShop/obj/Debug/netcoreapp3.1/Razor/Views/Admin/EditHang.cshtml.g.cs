#pragma checksum "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\EditHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d3f5d8d8b761818c3ccbe69ba1a301e63bc775"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditHang), @"mvc.1.0.view", @"/Views/Admin/EditHang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1d3f5d8d8b761818c3ccbe69ba1a301e63bc775", @"/Views/Admin/EditHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MobileShop.Models.Hangsanxuat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\EditHang.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"mt-2\" style=\"text-align:center\">Sửa hãng sản xuất</h2>\r\n");
#nullable restore
#line 7 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\EditHang.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 11 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\EditHang.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\EditHang.cshtml"
   Write(Html.HiddenFor(model => model.Mahang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label>Tên hãng</label>\r\n            ");
#nullable restore
#line 15 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\EditHang.cshtml"
       Write(Html.EditorFor(model => model.Tenhang, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\EditHang.cshtml"
       Write(Html.ValidationMessageFor(model => model.Tenhang, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        

        <div class=""form-group"">
            <div class=""col-md-offset-2 mb-1"">
                <input type=""submit"" value=""Sửa"" class=""btn btn-success"" />
                <a href=""/Admin/HangsanxuatIndex""><button class=""btn btn-danger"">Hủy</button></a>
            </div>
            ");
#nullable restore
#line 25 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\EditHang.cshtml"
       Write(Html.ActionLink("Xoá", "DeleteHang", new { id = Model.Mahang }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Admin\EditHang.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MobileShop.Models.Hangsanxuat> Html { get; private set; }
    }
}
#pragma warning restore 1591