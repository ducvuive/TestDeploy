#pragma checksum "E:\FileGit\Frame\framework_IS220.M11_11\DoAn_CuaHangLaptop\Test\Views\Home\User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63957f3f60795c1ff6540493d3a52497bc1ad77a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User), @"mvc.1.0.view", @"/Views/Home/User.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63957f3f60795c1ff6540493d3a52497bc1ad77a", @"/Views/Home/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b938626c1cb27b4184c87d029e4bd0625527155", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral(@"
<div class=""hero-wrap hero-bread"" style=""background-image: url(/images/bg_6.jpg);"">
    <div class=""container"">

        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Trang chủ ></a></span> <span>Trang cá nhân</span></p>
                
                <h1 class=""mb-0 bread"">About Us</h1>
            </div>
        </div>

        <div class=""nav flex-column nav-pills"" id=""v-pills-tab"" role=""tablist"" aria-orientation=""vertical"">
            <a class=""nav-link active"" id=""v-pills-info-tab"" data-toggle=""pill"" href=""#v-pills-info"" role=""tab"" aria-controls=""v-pills-info"" aria-selected=""true"">Thông tin cá nhân</a>
            <a class=""nav-link"" id=""v-pills-profile-tab"" data-toggle=""pill"" href=""#v-pills-profile"" role=""tab"" aria-controls=""v-pills-profile"" aria-selected=""false"">Thông tin đơn hàng</a>
            <a class=""nav-");
            WriteLiteral(@"link"" id=""v-pills-password-tab"" data-toggle=""pill"" href=""#v-pills-password"" role=""tab"" aria-controls=""v-pills-password"" aria-selected=""false"">Đổi mật khẩu</a>
        </div>
        <div class=""tab-content"" id=""v-pills-tabContent"">
            <div class=""tab-pane fade show active"" id=""v-pills-info"" role=""tabpanel"" aria-labelledby=""v-pills-info-tab"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63957f3f60795c1ff6540493d3a52497bc1ad77a4883", async() => {
                WriteLiteral(@"

                                <div class=""form-row"">
                                    <div class=""form-group col-md-6"">
                                        <div class=""container-fluid center"">
                                            <text>Tên đăng nhập:</text>
                                        </div>
                                    </div>

                                    <div class=""form-group col-md-6"">
                                        <div class=""container-fluid center"" id=""user_username"">
                                            <text>Demo</text>
                                        </div>
                                    </div>
                                </div>

                                <div class=""form-row"">
                                    <div class=""form-group col-md-6"">
                                        <div class=""container-fluid center"">
                                            <text>Tên khách hàng:</text>
    ");
                WriteLiteral(@"                                    </div>
                                    </div>

                                    <div class=""form-group col-md-6"">
                                        <div class=""container-fluid center"" id=""user_username"">
                                            <text>Nguyễn Văn A</text>
                                        </div>
                                    </div>
                                </div>

                                <div class=""form-row"">
                                    <div class=""form-group col-md-6"">
                                        <div class=""container-fluid center"">
                                            <text>Email:</text>
                                        </div>
                                    </div>

                                    <div class=""form-group col-md-6"">
                                        <div class=""container-fluid center"" id=""user_username"">
                             ");
                WriteLiteral(@"               <text>Demo</text>
                                        </div>
                                    </div>
                                </div>

                                <div class=""form-row"">
                                    <div class=""form-group col-md-6"">
                                        <div class=""container-fluid center"">
                                            <text>SĐT:</text>
                                        </div>
                                    </div>

                                    <div class=""form-group col-md-6"">
                                        <div class=""container-fluid center"" id=""user_username"">
                                            <text>0909123456</text>
                                        </div>
                                    </div>
                                </div>

                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""tab-pane fade"" id=""v-pills-profile"" role=""tabpanel"" aria-labelledby=""v-pills-profile-tab"">Demo1</div>
            <div class=""tab-pane fade"" id=""v-pills-password"" role=""tabpanel"" aria-labelledby=""v-pills-password-tab"">Demo2</div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591