#pragma checksum "D:\.netItem\OnlineBookstore\OnlineBookstore\OnlineBookstore\Views\Home\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "748f9a1f218815a2deed2a80495471c2d38821e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_login), @"mvc.1.0.view", @"/Views/Home/login.cshtml")]
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
#line 1 "D:\.netItem\OnlineBookstore\OnlineBookstore\OnlineBookstore\Views\_ViewImports.cshtml"
using OnlineBookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.netItem\OnlineBookstore\OnlineBookstore\OnlineBookstore\Views\_ViewImports.cshtml"
using OnlineBookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"748f9a1f218815a2deed2a80495471c2d38821e8", @"/Views/Home/login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ee74e4412f9b98f7c9c34b752341fea2c46200", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/verification.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\.netItem\OnlineBookstore\OnlineBookstore\OnlineBookstore\Views\Home\login.cshtml"
  
    ViewData["Title"] = "登录与注册";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #lock {
        height: 40px;
        background: beige;
        border-radius: 20px;
        width: 350px;
        position: relative;
        left: 0px;
    }

    #lock span {
        position: absolute;
        width: 60px;
        height: 40px;
        cursor: pointer;
        background-color: black;
        border-radius: 20px;
        text-align: center;
        line-height: 40px;
        margin-right: 0px;
    }
</style>
<ul class=""nav nav-tabs"">
    <li class=""nav-item"" style=""width:50%;"">
        <a class=""nav-link active"" href=""#"" onclick=""showlogin(this)"">登录</a>
    </li>
    <li class=""nav-item"" style=""width:50%;"">
        <a class=""nav-link"" href=""#"" onclick=""showRegistered(this)"">注册</a>
    </li>
</ul>
<div class=""centre"" style=""width: 30%;
        position: absolute;
        top: 25%;
        left: 35%;"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748f9a1f218815a2deed2a80495471c2d38821e85623", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label for=""inputEmail3"" class=""col-sm-2 control-label"">Account</label>
            <div class=""col-sm-10"">
                <input type=""email"" class=""form-control"" id=""inputEmail3"" placeholder=""Email"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputPassword3"" class=""col-sm-2 control-label"">Password</label>
            <div class=""col-sm-10"">
                <input type=""password"" class=""form-control"" id=""inputPassword3"" placeholder=""Password"">
            </div>
        </div>
        <div class=""form-group dname""  style=""display:none"">
            <label class=""col-sm-2 control-label"">Name</label>
            <div class=""col-sm-10"">
                <input type=""text"" class=""form-control""  id=""inputName""  placeholder=""Name"">
            </div>
        </div>
        <div class=""form-group"">
            <label for=""inputPassword3"" class=""col-sm-2 control-label"">Verification</label>
            <");
                WriteLiteral(@"div class=""col-sm-10"">
                <div id=""lock""><span></span></div>
            </div>
        </div>
        <div class=""form-group"">

            <div class=""col-sm-offset-2 col-sm-10"">
                <button type=""button"" class=""btn btn-primary login"" style=""margin-top: 20px; width: 100px;"" onclick=""login()"">登录</button>
                <button type=""button"" class=""btn btn-primary registered"" style=""margin-top: 20px;width: 100px;display:none;"" onclick=""registered()"">注册</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748f9a1f218815a2deed2a80495471c2d38821e88627", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "748f9a1f218815a2deed2a80495471c2d38821e89666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    function login() {
        var account = $(""#inputEmail3"").val().trim()
        var pass = $(""#inputPassword3"").val().trim()
        var isok = $(""#lock"").css(""background-color"");
        console.log(isok)
        if (account != """" && pass != """" && isok == ""rgb(0, 128, 0)"") {
            $.ajax({
                type: 'post',
                url: ""/Home/login"",
                data: { ""account"": account, ""password"": pass },
                datatype: 'json',
                success: function (res) {
                    console.log(res)
                    if (res != null) {
                        setCookie(""userId"", res.id)
                        setCookie(""userName"", res.userName)
                        if (res.account == ""admin"") {
                            window.location.href = '/Home/Management';
                        } else {
                            window.location.href = '/Home/index';
                        }
                    } else {
               ");
            WriteLiteral(@"         alert(""登录失败，请输入正确的账号密码"")
                    }
                }, error: function (err) {
                    console.log(err)
                    alert(""请求异常"")
                }
            });
        }
    }
    function setCookie(name, value) {
        var Days = 30;
        var exp = new Date();
        exp.setTime(exp.getTime() + Days * 24 * 60 * 60 * 1000);
        document.cookie = name + ""="" + escape(value) + "";expires="" + exp.toGMTString();
    }

    function registered() {
        var account = $(""#inputEmail3"").val().trim()
        var pass = $(""#inputPassword3"").val().trim()
        var userName = $(""#inputName"").val().trim()
        var isok = $(""#lock>span"").css(""background-color"");
        if (account != """" && pass != """" && isok == ""rgb(0, 0, 0)"" && userName!="""") {
            $.ajax({
                type: 'post',
                url: ""/Home/registered"",
                data: { ""account"": account, ""password"": pass, ""userName"": userName },
                da");
            WriteLiteral(@"tatype: 'json',
                success: function (res) {
                    console.log(res)
                    if (res == 1) {
                        alert(""注册成功！"")
                        location.reload();
                    } else {
                        alert(""注册失败！"")
                    }
                }, error: function (err) {
                    console.log(err)
                    alert(""请求异常"")
                }
            });
        }
    }
    function showRegistered(obj) {
        $("".dname"").css(""display"", ""block"")
        $("".active"").attr(""class"", ""nav-link"")
        $(obj).addClass(""active"");
        $("".login"").css(""display"", ""none"")
        $("".registered"").css(""display"", ""block"")
        $(""#inputEmail3"").val("""")
        $(""#inputPassword3"").val("""")
    }
    function showlogin(obj) {
        $("".dname"").css(""display"", ""none"")
        $("".active"").attr(""class"", ""nav-link"")
        $(obj).addClass(""active"");
        $("".login"").css(""display"", ""block"")");
            WriteLiteral("\r\n        $(\".registered\").css(\"display\", \"none\")\r\n    }\r\n</script>");
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
