#pragma checksum "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Store\GetStore.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e98c3a6f89e0476a39fa821f4cbbf08711c53ecf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_GetStore), @"mvc.1.0.view", @"/Views/Store/GetStore.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98c3a6f89e0476a39fa821f4cbbf08711c53ecf", @"/Views/Store/GetStore.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f28837082697f949a408f6188dcbc4b6d2a060d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_GetStore : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TicaretMVC.Models.Store>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Store\GetStore.cshtml"
  
    ViewData["Title"] = "GetStore";
    Layout = "~/Views/Shared/_MenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e98c3a6f89e0476a39fa821f4cbbf08711c53ecf3728", async() => {
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
    <b><label for=""groupname"">Ma??aza Ad??:</label></b>
    <input type=""text"" id=""groupname"" name=""groupname""");
            BeginWriteAttribute("value", " value=\"", 968, "\"", 992, 1);
#nullable restore
#line 28 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Store\GetStore.cshtml"
WriteAttributeValue("", 976, Model.groupname, 976, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><br><br>

    <button class=""btn btn-info"" id=""buttonn"">Ma??aza G??ncelle</button>
    <a href=""/Store/BackPage"" class=""btn btn-danger"">Geri</a>
</div>

<script>
    $(document).ready(function () {
        debugger;
        //$(""#dropdown"").select2();
        var groupid = ");
#nullable restore
#line 38 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Store\GetStore.cshtml"
                 Write(Model.groupid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        $(\"#buttonn\").click(function () {\r\n            debugger;\r\n            //var userid = $(\'#userid\').val();\r\n");
            WriteLiteral(@"            var groupname = $('#groupname').val();
            $.ajax({
                    type: 'POST',
                url: '/Store/UpdateStore',
                    data: {
                        groupid:groupid,
                        groupname: groupname,
                    },
                    /*data: '{groupid:' + dropvalue + ' }',*/
                    success: function (data) {
                        debugger
                        console.log('olduuuu')
                        window.location.href = '");
#nullable restore
#line 55 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Store\GetStore.cshtml"
                                           Write(Url.Action("Index","Store"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n                    },\r\n                    error: function (data) {\r\n                        debugger\r\n                        console.log(\'\')\r\n                    }\r\n                });\r\n            });\r\n        });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TicaretMVC.Models.Store> Html { get; private set; }
    }
}
#pragma warning restore 1591
