#pragma checksum "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f19fa5603c6071b820366ab47b393e90af4accf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
using TicaretMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f19fa5603c6071b820366ab47b393e90af4accf", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f28837082697f949a408f6188dcbc4b6d2a060d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Users>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h3>HOŞGELDİNİZ, ");
#nullable restore
#line 9 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
            Write(Context.Session.GetString("username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Kullanıcılar</th>
        <th>Roller</th>
        <th>E-Mail</th>
        <th>E-Mail Doğrulama</th>
        <th>Güncelle</th>
        <th>Detaylar</th>
        <th>Sil</th>
    </tr>
");
#nullable restore
#line 28 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 31 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
           Write(x.userid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
           Write(x.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
           Write(x.role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
           Write(x.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
           Write(x.emailconfirm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 876, "\"", 1014, 12);
            WriteAttributeValue("", 883, "/Users/GetUser?userid=", 883, 22, true);
#nullable restore
#line 36 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 905, x.userid, 905, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 914, "&username=", 914, 10, true);
#nullable restore
#line 36 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 924, x.username, 924, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 935, "&passsword=", 935, 11, true);
#nullable restore
#line 36 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 946, x.password, 946, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 957, "&role=", 957, 6, true);
#nullable restore
#line 36 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 963, x.role, 963, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 970, "&email=", 970, 7, true);
#nullable restore
#line 36 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 977, x.email, 977, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 985, "&emailconfirm=", 985, 14, true);
#nullable restore
#line 36 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 999, x.emailconfirm, 999, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1077, "\"", 1152, 6);
            WriteAttributeValue("", 1084, "/Users/DetailUser?userid=", 1084, 25, true);
#nullable restore
#line 37 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 1109, x.userid, 1109, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1118, "&username=", 1118, 10, true);
#nullable restore
#line 37 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 1128, x.username, 1128, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1139, "&role=", 1139, 6, true);
#nullable restore
#line 37 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 1145, x.role, 1145, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\" style=\"background-color:#ffd800\">Detaylar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1248, "\"", 1289, 2);
            WriteAttributeValue("", 1255, "/Users/DeleteUser?userid=", 1255, 25, true);
#nullable restore
#line 38 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
WriteAttributeValue("", 1280, x.userid, 1280, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Users\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/Users/NewUser/\" class=\"btn btn-primary\">Yeni Kullanıcı</a>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
