#pragma checksum "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Hoadon\HDDangGiao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e1eeaee6df05b431d143cd5b420893b536a806a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hoadon_HDDangGiao), @"mvc.1.0.view", @"/Views/Hoadon/HDDangGiao.cshtml")]
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
#line 1 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e1eeaee6df05b431d143cd5b420893b536a806a", @"/Views/Hoadon/HDDangGiao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce628290e7931cc4701d19d423f4cc50633f124a", @"/Views/_ViewImports.cshtml")]
    public class Views_Hoadon_HDDangGiao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Models.Hoadon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cthd", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CTHD", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Hoadon\HDDangGiao.cshtml"
  
    ViewData["Title"] = "HDDangGiao";
    Layout = "~/Areas/Identity/Pages/Account/Manage/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th>
               Ngày hóa đơn
            </th>
            <th>
                Người nhận
            </th>
            <th>
                Số điện thoại
            </th>
            <th>
                Địa chỉ giao hàng
            </th>
            <th>
                Thành tiền
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Hoadon\HDDangGiao.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 34 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Hoadon\HDDangGiao.cshtml"
           Write(item.Ngayhd.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Hoadon\HDDangGiao.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nguoinhan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 40 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Hoadon\HDDangGiao.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sdt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 43 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Hoadon\HDDangGiao.cshtml"
           Write(Html.DisplayFor(modelItem => item.Diachigiaohang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 46 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Hoadon\HDDangGiao.cshtml"
           Write(item.Thanhtien?.ToString("#,### VND"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1eeaee6df05b431d143cd5b420893b536a806a6661", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-mahd", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Hoadon\HDDangGiao.cshtml"
                                                               WriteLiteral(item.Mahd);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahd"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-mahd", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["mahd"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 52 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Hoadon\HDDangGiao.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.Models.Hoadon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
