#pragma checksum "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Users\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf93a7f87fc9be9d8cb0aedc37231044844a8f4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Login), @"mvc.1.0.view", @"/Views/Users/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf93a7f87fc9be9d8cb0aedc37231044844a8f4a", @"/Views/Users/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MobileShop.Models.Nguoidung>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Users\Login.cshtml"
  
    ViewBag.Title = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row justify-content-md-center\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                Login\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf93a7f87fc9be9d8cb0aedc37231044844a8f4a4362", async() => {
                WriteLiteral("\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 15 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Users\Login.cshtml"
                     using (Html.BeginForm("Login", "Home", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Users\Login.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 19 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Users\Login.cshtml"
                       Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 20 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Users\Login.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, "", new { @class = "form-control", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
#nullable restore
#line 24 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Users\Login.cshtml"
                       Write(Html.LabelFor(m => m.Matkhau));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
#nullable restore
#line 25 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Users\Login.cshtml"
                       Write(Html.PasswordFor(m => m.Matkhau, new { @class = "form-control", @placeholder = "Password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"submit\" name=\"submit\" class=\"btn btn-primary\" value=\"Login\" />\r\n                        </div>\r\n");
#nullable restore
#line 30 "C:\Users\This PC\Documents\GitHub\MobileShop-PRN211\MobileShop\Views\Users\Login.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
