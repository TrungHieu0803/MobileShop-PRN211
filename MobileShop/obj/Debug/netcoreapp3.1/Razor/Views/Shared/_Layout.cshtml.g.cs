#pragma checksum "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16418b20772b65bb48b14ad92b926eb4f59180af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
using MobileShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16418b20772b65bb48b14ad92b926eb4f59180af", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MobileShop.Models.Nguoidung>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString(" stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.unobtrusive-ajax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.unobtrusive-ajax.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.4.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.4.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16418b20772b65bb48b14ad92b926eb4f59180af6950", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
#nullable restore
#line 6 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" -PRN211- group 6</title>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16418b20772b65bb48b14ad92b926eb4f59180af7596", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "16418b20772b65bb48b14ad92b926eb4f59180af8774", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16418b20772b65bb48b14ad92b926eb4f59180af10077", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16418b20772b65bb48b14ad92b926eb4f59180af11177", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16418b20772b65bb48b14ad92b926eb4f59180af12277", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16418b20772b65bb48b14ad92b926eb4f59180af13377", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral(@"   
    <style type=""text/css"">
        body {
            background-color: #F0F0F0;
        }

        .navbar-inverse {
            background-color: #39B54A;
            border-color: #39B54A;
        }

        .top_header {
            background-color: black;
            padding-left: 110px;
            color: white;
        }

        .form-inline {
            float: right;
            padding-top: 10px;
        }

        .navbar-inverse .navbar-nav > li > a {
            color: white;
            font-size: x-large;
        }

        .navbar-inverse .navbar-brand {
            color: white;
        }

        .navbar-inverse .navbar-nav > li > a {
            color: white;
            font-size: large;
        }

            .navbar-inverse .navbar-nav > li > a:hover {
                color: black;
            }

        .navbar-brand {
            color: cadetblue;
        }

        .spnoibat {
            background-color: white;
        }

      ");
                WriteLiteral("      .spnoibat h3 {\r\n                padding-left: 30px;\r\n            }\r\n\r\n        .giohang {\r\n            color: white;\r\n        }\r\n    </style>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16418b20772b65bb48b14ad92b926eb4f59180af16458", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 80 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
       var u = TempData["User"] as Nguoidung; 

#line default
#line hidden
#nullable disable
                WriteLiteral("   \r\n    <div class=\"navbar navbar-inverse navbar-fixed-top\" style=\"background-color: #19194d \">\r\n\r\n        <div class=\"top_header col-md-12\">\r\n\r\n            <div class=\"row\" style=\"text-align:center\">\r\n\r\n");
#nullable restore
#line 88 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
                   if (u != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"col-sm-4 col-md-0\">\r\n            Xin chào : ");
#nullable restore
#line 91 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
                  Write(u.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n            <a style=\"color:red\" href=\"/Users/Logout\"> ĐĂNG XUẤT</a>\r\n        </div> ");
#nullable restore
#line 95 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
               }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"col-sm-4 col-md-0\">\r\n    <a style=\"color:white\" href=\"/Users/Login\"> Đăng nhập</a>\r\n\r\n    <a style=\"color:white\" href=\"/Users/Register\"> Đăng ký</a>\r\n</div> ");
#nullable restore
#line 102 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
       } 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>

        </div>
        <div class=""container"">

            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <img class=""navbar-brand"" src=""https://cdn-icons-png.flaticon.com/512/438/438560.png"" width=""50"" height=""50"" style=""padding:0"" />
                ");
#nullable restore
#line 116 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
           Write(Html.ActionLink("Mobile Shop - PRN211", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


            </div>

            <div class=""navbar-collapse collapse"">

                <ul class=""nav navbar-nav"">
                    <li>
                        <a href=""#"" title=""dienthoai"">
                            <span>ĐIỆN THOẠI</span>
                        </a>
                    </li>
                    <li>
                        <a href=""#"" title=""PHUKIEN"">
                            <span>PHỤ KIỆN</span>
                        </a>
                    </li>
                    <li>
                        <a style=""color:white""
                           class=""nav-link""");
                BeginWriteAttribute("href", "\r\n                           href=\"", 3908, "\"", 3975, 1);
#nullable restore
#line 137 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3943, Url.Action("Index", "DonHangs"), 3943, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">ĐƠN HÀNG</a>\r\n                    </li>\r\n                    <li>\r\n                        ");
#nullable restore
#line 140 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
                   Write(Html.ActionLink("GioHangPartial", "GioHang", new { @class = "nav-link" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </li>\r\n                    <li>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16418b20772b65bb48b14ad92b926eb4f59180af20958", async() => {
                    WriteLiteral(@"
                            <input class=""form-control mr-sm-2"" type=""search"" placeholder=""Search here ..."" aria-label=""Search"">
                            <button class=""btn btn-outline-success my-2 my-sm-0"" type=""submit"">Search</button>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <br>\r\n    <div class=\"container body-content\">\r\n        ");
#nullable restore
#line 155 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <hr />
        <div>
            <img class=""img-responsive"" src=""https://cdn.tgdd.vn/2021/10/banner/1200-44-1200x44-3.png"" />
        </div>
        <br />
    </div>
    <footer style="" background-color: #19194d; color: white"">
        <center> <p>&copy; ");
#nullable restore
#line 163 "C:\Users\Admin\Desktop\MobileShop-PRN211\MobileShop\Views\Shared\_Layout.cshtml"
                      Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - PRN211 - Group 6</p></center>\r\n    </footer>\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MobileShop.Models.Nguoidung> Html { get; private set; }
    }
}
#pragma warning restore 1591
