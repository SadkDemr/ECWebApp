#pragma checksum "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Shared\Components\FeaturedProducts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ff9b09a5acfa1df1d857e22f767631143d7b27c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeaturedProducts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeaturedProducts/Default.cshtml")]
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
#line 1 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\_ViewImports.cshtml"
using ECWebApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\_ViewImports.cshtml"
using ECWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ff9b09a5acfa1df1d857e22f767631143d7b27c", @"/Views/Shared/Components/FeaturedProducts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8998d1085e5ead66cf15cdd847e6ad6f068181da", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_FeaturedProducts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"widget\">\r\n    <h4>FEATURED</h4>\r\n\r\n    <div class=\"products-list\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Shared\Components\FeaturedProducts\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"media\">\r\n                <a class=\"media-left\" href=\"#\">\r\n                    <img");
            BeginWriteAttribute("alt", " alt=\"", 268, "\"", 274, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive product-thumb\"");
            BeginWriteAttribute("src", " src=\"", 312, "\"", 349, 2);
            WriteAttributeValue("", 318, "/images/products/tn/", 318, 20, true);
#nullable restore
#line 12 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Shared\Components\FeaturedProducts\Default.cshtml"
WriteAttributeValue("", 338, item.Image, 338, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                </a>\r\n\r\n                <div class=\"media-body\">\r\n                    <a href=\"#\" class=\"product-title\">");
#nullable restore
#line 17 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Shared\Components\FeaturedProducts\Default.cshtml"
                                                 Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                   \r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Shared\Components\FeaturedProducts\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
