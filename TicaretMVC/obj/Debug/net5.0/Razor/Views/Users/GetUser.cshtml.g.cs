#pragma checksum "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\GetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305a2ca1247fdb34814e2426be019459a8327c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_GetUser), @"mvc.1.0.view", @"/Views/Users/GetUser.cshtml")]
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
#line 1 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\_ViewImports.cshtml"
using TicaretMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\_ViewImports.cshtml"
using TicaretMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305a2ca1247fdb34814e2426be019459a8327c7f", @"/Views/Users/GetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f28837082697f949a408f6188dcbc4b6d2a060d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_GetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicaretMVC.Models.Users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "role", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\GetUser.cshtml"
  
    ViewData["Title"] = "GetUser";
    Layout = "~/Views/Shared/_MenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305a2ca1247fdb34814e2426be019459a8327c7f4147", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">

<div>
    <b><label for=""username"">Kullan??c?? Ad??:</label></b>
    <input type=""text"" id=""username"" name=""username""");
            BeginWriteAttribute("value", " value=\"", 454, "\"", 477, 1);
#nullable restore
#line 14 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\GetUser.cshtml"
WriteAttributeValue("", 462, Model.username, 462, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><br><br>\r\n\r\n    <b><label for=\"password\">Kullan??c?? ??ifresi:</label></b>\r\n    <input type=\"password\" id=\"password\" name=\"password\"");
            BeginWriteAttribute("value", " value=\"", 608, "\"", 631, 1);
#nullable restore
#line 17 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\GetUser.cshtml"
WriteAttributeValue("", 616, Model.password, 616, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><br><br>\r\n    \r\n    <b><label for=\"email\">E-Mail</label></b>\r\n    <input type=\"text\" id=\"email\" name=\"email\"");
            BeginWriteAttribute("value", " value=\"", 741, "\"", 761, 1);
#nullable restore
#line 20 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\GetUser.cshtml"
WriteAttributeValue("", 749, Model.email, 749, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><br><br>\r\n\r\n    <b><label for=\"role\">Kullan??c?? Rol??:</label></b>\r\n    <select name=\"deneme2\" id=\"dropdown2\">\r\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305a2ca1247fdb34814e2426be019459a8327c7f6964", async() => {
#nullable restore
#line 26 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\GetUser.cshtml"
                      Write(ViewBag.deger1);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "305a2ca1247fdb34814e2426be019459a8327c7f8291", async() => {
#nullable restore
#line 27 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\GetUser.cshtml"
                      Write(ViewBag.deger2);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"    </select>
    <br />
    <br />

    <button class=""btn btn-info"" id=""buttonn"">Kullan??c?? G??ncelle</button>
    <a href=""/Users/BackPage"" class=""btn btn-danger"">Geri</a>
</div>

<script>
    $(document).ready(function () {
        //$(""#dropdown"").select2();
        var userid = ");
#nullable restore
#line 40 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\GetUser.cshtml"
                Write(Model.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        $(\"#buttonn\").click(function () {\r\n            debugger;\r\n            //var userid = $(\'#userid\').val();\r\n");
            WriteLiteral(@"            var username = $('#username').val();
            var password = $('#password').val();
            var email = $('#email').val();
            var dropvalue = $('#dropdown :selected').val();
                $.ajax({
                    type: 'POST',
                    url: '/Users/UpdateUser',
                    data: {
                        userid:userid,
                        username: username,
                        password:password,
                        email: email,
                        role:dropvalue
                    },
                    /*data: '{groupid:' + dropvalue + ' }',*/
                    success: function (data) {
                        debugger
                        console.log('olduuuu')
                        window.location.href = '");
#nullable restore
#line 63 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\GetUser.cshtml"
                                           Write(Url.Action("Index","Users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n                    },\r\n                    error: function (data) {\r\n                        debugger\r\n                        console.log(\'\')\r\n                    }\r\n                });\r\n            });\r\n        });\r\n</script>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicaretMVC.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
