#pragma checksum "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdf908517b60e53807e8c8d33a87ca32fcc9da5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PagingXTL), @"mvc.1.0.view", @"/Views/Shared/_PagingXTL.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdf908517b60e53807e8c8d33a87ca32fcc9da5d", @"/Views/Shared/_PagingXTL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce628290e7931cc4701d19d423f4cc50633f124a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PagingXTL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<XTL.Helpers.PagingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 9 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
  
    int currentPage = Model.currentpage;
    int countPages = Model.countpages;
    var generateUrl = Model.generateUrl;



    if (currentPage > countPages)
        currentPage = countPages;

    if (countPages <= 1) return;


    int? preview = null;
    int? next = null;

    if (currentPage > 1)
        preview = currentPage - 1;

    if (currentPage < countPages)
        next = currentPage + 1;

    // Các trang hiện thị trong điều hướng
    List<int> pagesRanges = new List<int>();


    int delta = 5;             // Số trang mở rộng về mỗi bên trang hiện tại
    int remain = delta * 2;     // Số trang hai bên trang hiện tại

    pagesRanges.Add(currentPage);
    // Các trang phát triển về hai bên trang hiện tại
    for (int i = 1; i <= delta; i++)
    {
        if (currentPage + i <= countPages)
        {
            pagesRanges.Add(currentPage + i);
            remain--;
        }

        if (currentPage - i >= 1)
        {
            pagesRanges.Insert(0, currentPage - i);
            remain--;
        }

    }
    // Xử lý thêm vào các trang cho đủ remain
    //(xảy ra ở đầu mút của khoảng trang không đủ trang chèn  vào)
    if (remain > 0)
    {
        if (pagesRanges[0] == 1)
        {
            for (int i = 1; i <= remain; i++)
            {
                if (pagesRanges.Last() + 1 <= countPages)
                {
                    pagesRanges.Add(pagesRanges.Last() + 1);
                }
            }
        }
        else
        {
            for (int i = 1; i <= remain; i++)
            {
                if (pagesRanges.First() - 1 > 1)
                {
                    pagesRanges.Insert(0, pagesRanges.First() - 1);
                }
            }
        }
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<ul class=\"pagination\">\n    <!-- Previous page link -->\n");
#nullable restore
#line 87 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
     if (preview != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2125, "\"", 2153, 1);
#nullable restore
#line 90 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
WriteAttributeValue("", 2132, generateUrl(preview), 2132, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang trước</a>\n        </li>\n");
#nullable restore
#line 92 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item disabled\">\n            <a class=\"page-link\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\">Trang trước</a>\n        </li>\n");
#nullable restore
#line 98 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <!-- Numbered page links -->\n");
#nullable restore
#line 101 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
     foreach (var pageitem in pagesRanges)
    {
        if (pageitem != currentPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2560, "\"", 2589, 1);
#nullable restore
#line 106 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
WriteAttributeValue("", 2567, generateUrl(pageitem), 2567, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    ");
#nullable restore
#line 107 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
               Write(pageitem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </a>\n            </li>\n");
#nullable restore
#line 110 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\" aria-current=\"page\">\n                <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 114 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
                                         Write(pageitem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\n            </li>\n");
#nullable restore
#line 116 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <!-- Next page link -->\n");
#nullable restore
#line 121 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
     if (next != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3011, "\"", 3036, 1);
#nullable restore
#line 124 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
WriteAttributeValue("", 3018, generateUrl(next), 3018, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang sau</a>\n        </li>\n");
#nullable restore
#line 126 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item disabled\">\n            <a class=\"page-link\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\">Trang sau</a>\n        </li>\n");
#nullable restore
#line 132 "E:\FileGit\framework_IS220.M11_11-main\framework_IS220.M11_11-main\DoAn_CuaHangLaptop\Test\Views\Shared\_PagingXTL.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<XTL.Helpers.PagingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
