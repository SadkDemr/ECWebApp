#pragma checksum "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bdc017b5bf0475df6e7f524e473953cdec57a82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditProduct), @"mvc.1.0.view", @"/Views/Admin/EditProduct.cshtml")]
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
#line 1 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\_ViewImports.cshtml"
using ECWebApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\_ViewImports.cshtml"
using ECWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bdc017b5bf0475df6e7f524e473953cdec57a82", @"/Views/Admin/EditProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df388a0c0a04755310f20216e0c9ff8d23653e73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_EditProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
   ViewData["Title"] = "EditProduct";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container pb-5 pt-3\">\r\n\r\n    <h2>Ürün Güncelleme</h2>\r\n    <hr />\r\n\r\n");
#nullable restore
#line 13 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    ");
#nullable restore
#line 18 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 19 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
Write(Html.HiddenFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 22 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
   Write(Html.LabelFor(model => model.ProductName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
       Write(Html.EditorFor(model => model.ProductName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
       Write(Html.ValidationMessageFor(model => model.ProductName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 30 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
   Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
       Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
       Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 38 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
   Write(Html.LabelFor(model => model.Attributes, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
       Write(Html.EditorFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 41 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
       Write(Html.ValidationMessageFor(model => model.Attributes, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 46 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
   Write(Html.LabelFor(model => model.Image, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
       Write(Html.EditorFor(model => model.Image, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 49 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
       Write(Html.ValidationMessageFor(model => model.Image, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 54 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
   Write(Html.LabelFor(model => model.IsHome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <div class=\"checkbox\">\r\n                ");
#nullable restore
#line 57 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
           Write(Html.EditorFor(model => model.IsHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 58 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.IsHome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 64 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
   Write(Html.LabelFor(model => model.IsApproved, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <div class=\"checkbox\">\r\n                ");
#nullable restore
#line 67 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
           Write(Html.EditorFor(model => model.IsApproved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 68 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
           Write(Html.ValidationMessageFor(model => model.IsApproved, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group pt-3\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Kaydet\" class=\"btn btn-success\" />\r\n            ");
#nullable restore
#line 77 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
       Write(Html.ActionLink("Listeye Dön", "CatalogList", null, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 81 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\EditProduct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
