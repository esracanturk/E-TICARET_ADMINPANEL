#pragma checksum "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b6ba38dd87ea686aeaf88d44efb612df6d9f79b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_GetAllProduct), @"mvc.1.0.view", @"/Views/Products/GetAllProduct.cshtml")]
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
#line 1 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
using TicaretMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b6ba38dd87ea686aeaf88d44efb612df6d9f79b", @"/Views/Products/GetAllProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f28837082697f949a408f6188dcbc4b6d2a060d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_GetAllProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductsWithStore>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
  
    ViewData["Title"] = "GetAllProduct";
    Layout = "~/Views/Shared/_MenuLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Name</th>
        <th>Quantity</th>
        <th>Price</th>
        <th>Ma??aza</th>
        <th>Kategori</th>
        <th>G??ncelle</th>
        <th>Detaylar</th>
        <th>Sil</th>
    </tr>
");
#nullable restore
#line 22 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 25 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
           Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
           Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
           Write(x.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
           Write(x.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
           Write(x.groupname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            <td><a");
            BeginWriteAttribute("href", " href=\"", 743, "\"", 997, 18);
            WriteAttributeValue("", 750, "/Products/GetProduct?Id=", 750, 24, true);
#nullable restore
#line 31 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 774, x.Id, 774, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 779, "&Name=", 779, 6, true);
#nullable restore
#line 31 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 785, x.Name, 785, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 792, "&Quantity=", 792, 10, true);
#nullable restore
#line 31 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 802, x.Quantity, 802, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 813, "&Price=", 813, 7, true);
#nullable restore
#line 31 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 820, x.Price, 820, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 828, "&ImageUrl=", 828, 10, true);
#nullable restore
#line 31 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 838, x.ImageUrl, 838, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 849, "&Description=", 849, 13, true);
#nullable restore
#line 31 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 862, x.Description, 862, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 876, "&", 876, 1, true);
            WriteAttributeValue("\r\n                   ", 877, "groupid=", 898, 29, true);
#nullable restore
#line 32 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 906, x.groupid, 906, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 916, "&groupname=", 916, 11, true);
#nullable restore
#line 32 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 927, x.groupname, 927, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 939, "@*&KategoriID=@x.KategoriID&KategoriName=@x.KategoriName*@", 939, 58, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">G??ncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1060, "\"", 1317, 18);
            WriteAttributeValue("", 1067, "/Products/DetailProduct?Id=", 1067, 27, true);
#nullable restore
#line 33 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 1094, x.Id, 1094, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1099, "&Name=", 1099, 6, true);
#nullable restore
#line 33 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 1105, x.Name, 1105, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1112, "&Quantity=", 1112, 10, true);
#nullable restore
#line 33 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 1122, x.Quantity, 1122, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1133, "&Price=", 1133, 7, true);
#nullable restore
#line 33 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 1140, x.Price, 1140, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1148, "&", 1148, 1, true);
            WriteAttributeValue("\r\n                   ", 1149, "Description=", 1170, 33, true);
#nullable restore
#line 34 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 1182, x.Description, 1182, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1196, "&ImageUrl=", 1196, 10, true);
#nullable restore
#line 34 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 1206, x.ImageUrl, 1206, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1217, "&groupid=", 1217, 9, true);
#nullable restore
#line 34 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 1226, x.groupid, 1226, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1236, "&groupname=", 1236, 11, true);
#nullable restore
#line 34 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 1247, x.groupname, 1247, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1259, "@*&KategoriID=@x.KategoriID&KategoriName=@x.KategoriName*@", 1259, 58, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\" style=\"background-color:#ffd800\">Detaylar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1413, "\"", 1452, 2);
            WriteAttributeValue("", 1420, "/Products/ProductDelete?Id=", 1420, 27, true);
#nullable restore
#line 35 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
WriteAttributeValue("", 1447, x.Id, 1447, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\aa\source\repos\TicaretAPI\TicaretMVC\Views\Products\GetAllProduct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/Products/NewProduct/\" class=\"btn btn-primary\">Yeni ??r??n</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductsWithStore>> Html { get; private set; }
    }
}
#pragma warning restore 1591
