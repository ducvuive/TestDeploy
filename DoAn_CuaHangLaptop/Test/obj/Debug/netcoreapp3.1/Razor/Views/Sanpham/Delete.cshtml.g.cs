#pragma checksum "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed24301879db069ff5afe38b823987114e81ee91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sanpham_Delete), @"mvc.1.0.view", @"/Views/Sanpham/Delete.cshtml")]
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
#line 1 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed24301879db069ff5afe38b823987114e81ee91", @"/Views/Sanpham/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Sanpham_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test.Models.Sanpham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Sanpham</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tensp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tensp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Soluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Soluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mausac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mausac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ocung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ocung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cardmanhinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cardmanhinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dacbiet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dacbiet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hdh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hdh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Thietke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Thietke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.KichthuocTrongluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.KichthuocTrongluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Webcam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Webcam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ramat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ramat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dongia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dongia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinhanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hinhanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BoxulyNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BoxulyNavigation.Mabxl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CongketnoiNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CongketnoiNavigation.Mackn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DanhmucNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DanhmucNavigation.Madm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ManhinhNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ManhinhNavigation.Mamh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RamNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RamNavigation.Maram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed24301879db069ff5afe38b823987114e81ee9118293", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed24301879db069ff5afe38b823987114e81ee9118560", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 137 "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Sanpham\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Masp);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed24301879db069ff5afe38b823987114e81ee9120362", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Models.Sanpham> Html { get; private set; }
    }
}
#pragma warning restore 1591