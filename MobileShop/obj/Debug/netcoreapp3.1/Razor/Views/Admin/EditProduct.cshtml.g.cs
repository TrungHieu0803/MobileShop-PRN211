#pragma checksum "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1f5d53d1a0d5006fa8132331f3d8b2b7fe18729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditProduct), @"mvc.1.0.view", @"/Views/Admin/EditProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f5d53d1a0d5006fa8132331f3d8b2b7fe18729", @"/Views/Admin/EditProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MobileShop.Models.Sanpham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Thesim"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Thesim", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Sanphammoi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Sanphammoi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAnh", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
  
    ViewBag.Title = "EditProduct";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"mt-2\" style=\"text-align:center\">Sửa sản phẩm</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 9 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-horizontal row\">\r\n                <hr />\r\n                ");
#nullable restore
#line 13 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 14 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
           Write(Html.HiddenFor(model => model.Masp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"form-group col-md-6\">\r\n                    <label>Tên sản phẩm</label>\r\n                    ");
#nullable restore
#line 17 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.EditorFor(model => model.Tensp, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 18 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.Tensp, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label>Giá tiền</label>\r\n                    ");
#nullable restore
#line 22 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.EditorFor(model => model.Giatien, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.Giatien, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label>Số lượng</label>\r\n                    ");
#nullable restore
#line 27 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.EditorFor(model => model.Soluong, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.Soluong, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label>Ảnh</label>\r\n                    ");
#nullable restore
#line 32 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.EditorFor(model => model.Anhbia, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.Anhbia, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-2\">\r\n                    <label>Ram</label>\r\n                    ");
#nullable restore
#line 37 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.EditorFor(model => model.Ram, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.Ram, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-2\">\r\n                    <label>Bộ nhớ trong</label>\r\n                    ");
#nullable restore
#line 42 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.EditorFor(model => model.Bonhotrong, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 43 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.Bonhotrong, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-2\">\r\n                    <label>Thẻ sim</label>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f5d53d1a0d5006fa8132331f3d8b2b7fe1872912196", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f5d53d1a0d5006fa8132331f3d8b2b7fe1872912481", async() => {
                    WriteLiteral("1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f5d53d1a0d5006fa8132331f3d8b2b7fe1872913515", async() => {
                    WriteLiteral("2");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 47 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Thesim);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
#nullable restore
#line 51 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.Thesim, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-3\">\r\n                    <label>Sản phẩm mới</label>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f5d53d1a0d5006fa8132331f3d8b2b7fe1872916645", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f5d53d1a0d5006fa8132331f3d8b2b7fe1872916930", async() => {
                    WriteLiteral("True");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f5d53d1a0d5006fa8132331f3d8b2b7fe1872917967", async() => {
                    WriteLiteral("False");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 55 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Sanphammoi);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
#nullable restore
#line 59 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.Sanphammoi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-3\">\r\n                    <label>Hãng sản xuất</label>\r\n                    ");
#nullable restore
#line 63 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.DropDownList("Mahang", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 64 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.Mahang, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-12\">\r\n                    <label>Mô tả</label>\r\n                    ");
#nullable restore
#line 68 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.EditorFor(model => model.Mota, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 69 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ValidationMessageFor(model => model.Mota, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""form-group"">
                    <div class=""col-md-offset-2 mb-1"">
                        <input type=""submit"" value=""Sửa"" class=""btn btn-success"" />
                        <a href=""/Admin/Index""><button class=""btn btn-danger"">Hủy</button></a>
                    </div>
                    ");
#nullable restore
#line 76 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
               Write(Html.ActionLink("Xoá sản phẩm", "DeleteProduct", new { id = Model.Masp }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 79 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <div class=""col-md-6"">
        <h4 class=""mt-2"" style=""text-align:center"">Chọn màu</h4>
        <div class=""table-wrapper-scroll-y my-custom-scrollbar"">
            <table class=""table table-bordered table-striped mb-0"">
                <thead>
                    <tr>
                        <th scope=""col"">Màu</th>
                        <th scope=""col"">Chọn</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 92 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                     foreach (var mau in ViewBag.Mau)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 95 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                           Write(mau.Tenmau);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 96 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                              
                                int count = 0;
                                foreach (var maudachon in ViewBag.MauDaChon)
                                {
                                    if (maudachon.Mamau == mau.Mamau)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 102 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                                       Write(Html.ActionLink("Bỏ màu", "DeleteMauSanpham", "Admin", new { masp = Model.Masp, mamau = mau.Mamau }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 103 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                                        count++;
                                    }
                                }
                                if (count == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 108 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                                   Write(Html.ActionLink("Thêm màu", "AddMauSanpham", "Admin", new { masp = Model.Masp, mamau = mau.Mamau }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 109 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 112 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f5d53d1a0d5006fa8132331f3d8b2b7fe1872927056", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <input type=\"hidden\" name=\"masp\"");
                BeginWriteAttribute("value", " value=\"", 6435, "\"", 6454, 1);
#nullable restore
#line 120 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 6443, Model.Masp, 6443, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <div class=""col-10"">
                    <input type=""text"" name=""url"" placeholder=""Dán link ảnh"" class=""form-control"" />
                </div>
                <div class=""col-2"">
                    <input type=""submit"" name=""submit"" class=""btn btn-primary"" value=""Thêm ảnh"" />
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""table-wrapper-scroll-y my-custom-scrollbar"" style=""margin-top:5px"">
            <table class=""table table-bordered table-striped mb-0"">
                <thead>
                    <tr>
                        <th scope=""col"">Link ảnh</th>
                        <th scope=""col"">Xóa ảnh</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 138 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                     foreach (var anh in ViewBag.Anh)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 141 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                           Write(anh.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 142 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                           Write(Html.ActionLink("Xóa ảnh", "DeleteAnh", "Admin", new { id = anh.Maanh }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 144 "D:\Learning\FPT U\Ki5\PRN211\Project\MobileShop-PRN211\MobileShop\Views\Admin\EditProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MobileShop.Models.Sanpham> Html { get; private set; }
    }
}
#pragma warning restore 1591
