#pragma checksum "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f4fa5ffa3240ee000bac69dec537b58b9348e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_CheckoutCompleto), @"mvc.1.0.view", @"/Views/Order/CheckoutCompleto.cshtml")]
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
#line 1 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/_ViewImports.cshtml"
using Tobacco_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/_ViewImports.cshtml"
using Tobacco_Shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/_ViewImports.cshtml"
using Tobacco_Shop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f4fa5ffa3240ee000bac69dec537b58b9348e8", @"/Views/Order/CheckoutCompleto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0bcb81a07d7e4d9db3901cb7f6b2cc7192be828", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CheckoutCompleto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container marginTop1\">\r\n\r\n    <div class=\"jumbotron\">\r\n        <h2>");
#nullable restore
#line 6 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
       Write(ViewBag.CheckoutCompleteMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <p>Client : <strong>");
#nullable restore
#line 10 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            <p>Date of Order :  <strong>");
#nullable restore
#line 11 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
                                   Write(Model.OrderSend);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            <p>Number of Order   : <strong>");
#nullable restore
#line 12 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
                                      Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n            <table class=\"table\">\r\n              <tr>\r\n                <th></th>\r\n                <th>Quantity</th>\r\n                <th>Tobacco</th>\r\n                <th>Price</th>\r\n              </tr>\r\n");
#nullable restore
#line 20 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
               foreach (var item in Model.OrderItens)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <tr>\r\n                   <td><img");
            BeginWriteAttribute("src", " src=\"", 719, "\"", 747, 1);
#nullable restore
#line 23 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
WriteAttributeValue("", 725, item.Tobacco.ImageURL, 725, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40\" height=\"40\" /></td>\r\n                   <td>");
#nullable restore
#line 24 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
                  Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 25 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
                  Write(item.Tobacco.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 26 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
                  Write(item.Tobacco.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  </tr>\r\n");
#nullable restore
#line 28 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            <h4>Total Cost of Order: <strong>");
#nullable restore
#line 30 "/home/novais/Desktop/Projetos/Tobacco_Shop/Views/Order/CheckoutCompleto.cshtml"
                                         Write(((decimal)ViewBag.TotalOrder).ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591