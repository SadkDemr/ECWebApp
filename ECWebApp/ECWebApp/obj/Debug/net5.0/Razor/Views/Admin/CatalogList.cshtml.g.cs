<<<<<<< HEAD
#pragma checksum "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52845172cc3909e2baaae36e353334ba4a9c7d76"
=======
#pragma checksum "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81a7fadf3d50d5e2a1e11d36de949018a468623a"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CatalogList), @"mvc.1.0.view", @"/Views/Admin/CatalogList.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\_ViewImports.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
using ECWebApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\_ViewImports.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
using ECWebApp.Models;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52845172cc3909e2baaae36e353334ba4a9c7d76", @"/Views/Admin/CatalogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df388a0c0a04755310f20216e0c9ff8d23653e73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81a7fadf3d50d5e2a1e11d36de949018a468623a", @"/Views/Admin/CatalogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df388a0c0a04755310f20216e0c9ff8d23653e73", @"/Views/_ViewImports.cshtml")]
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
    public class Views_Admin_CatalogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatalogListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 2 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
   ViewData["Title"] = "CatalogList";
                Layout = "~/Views/Shared/_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Catalog</h2>
<hr />
<div class=""card"">
    <div class=""card-header"">
        Categories
    </div>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>CategoryName</th>
                <th style=""width:135px;""></th>
            </tr>
        </thead>
        <tbody id=""categories"">

");
#nullable restore
<<<<<<< HEAD
#line 20 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 20 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
<<<<<<< HEAD
#line 23 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 23 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
   Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
<<<<<<< HEAD
#line 24 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 24 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52845172cc3909e2baaae36e353334ba4a9c7d766814", async() => {
                WriteLiteral("\n            Edit\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
<<<<<<< HEAD
#line 26 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
                                                              WriteLiteral(item.CategoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <button class=\"btn btn-danger btn-sm\">Delete</button>\n    </td>\n</tr>            ");
#nullable restore
#line 31 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 29 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n\n    <div class=\"card-footer\">\n        <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#addCategoryModal\">Create</button>\n\n        ");
#nullable restore
<<<<<<< HEAD
#line 39 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 37 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
   Write(Html.Partial("_addCategoryForm", new Category()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

            <script>
                $(""#addCategory"").submit(function (event) {

                    event.preventDefault();
                    var form = $(this);

                    var token = $('input[name=""__RequestVerificationToken""]', form).val();
                    var data = { categoryName: $(""#CategoryName"").val() };
                    var dataWithToken = $.extend(data, { '__RequestVerificationToken': token });

                    $.ajax({
                        url: form.attr(""action""),
                        type: ""POST"",
                        data: dataWithToken,
                        beforeSend: function () {
                            $(""#ajax-loader"").show();
                        },
                        complete: function () {
                            $(""#ajax-loader"").hide();
                        },
                        success: function (data) {

                            var html = '<tr><td>' + data.categoryId + '</td><td>' + data.categoryName + '</td><td><bu");
                WriteLiteral(@"tton class=""btn btn-primary btn-sm"">Edit</button><button class=""btn btn-danger btn-sm"">Delete</button></td></tr>';
                            $(""#categories"").append(html);
                            $(""#addCategoryModal"").modal('hide');
                        },
                        error: function () {

                        }
                    });


                });


            </script>

        ");
            }
            );
            WriteLiteral(@"
    </div>
</div>
<hr />

<div class=""card"">
    <div class=""card-header"">
        Products
    </div>

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>#</th>
                <th>Image</th>
                <th>ProductName</th>
                <th>IsApproved</th>
                <th>IsHome</th>
                <th>IsFeatured</th>
                <th style=""width:135px;""></th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
<<<<<<< HEAD
#line 104 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 98 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
             foreach (var item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <th>");
#nullable restore
<<<<<<< HEAD
#line 107 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 101 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    <td>\n        ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52845172cc3909e2baaae36e353334ba4a9c7d7612822", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81a7fadf3d50d5e2a1e11d36de949018a468623a9660", async() => {
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3171, "~/images/products/tn/", 3171, 21, true);
#nullable restore
<<<<<<< HEAD
#line 109 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
AddHtmlAttributeValue("", 3192, item.Image, 3192, 11, false);
=======
#line 103 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
AddHtmlAttributeValue("", 3054, item.Image, 3054, 11, false);
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </td>\n    <td>");
#nullable restore
<<<<<<< HEAD
#line 111 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 105 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n");
#nullable restore
<<<<<<< HEAD
#line 113 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 107 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
         if (item.IsApproved)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"check-square\"></span> ");
#nullable restore
<<<<<<< HEAD
#line 115 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 109 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
                                          }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"x-square\"></span>");
#nullable restore
<<<<<<< HEAD
#line 118 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 112 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\n    <td>\n");
#nullable restore
<<<<<<< HEAD
#line 121 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 115 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
         if (item.IsHome)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"check-square\"></span> ");
#nullable restore
<<<<<<< HEAD
#line 123 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 117 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
                                          }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"x-square\"></span>");
#nullable restore
<<<<<<< HEAD
#line 126 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 120 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\n    <td>\n");
#nullable restore
<<<<<<< HEAD
#line 129 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 123 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
         if (item.IsFeatured)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"check-square\"></span> ");
#nullable restore
<<<<<<< HEAD
#line 131 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 125 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
                                          }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"x-square\"></span>");
#nullable restore
<<<<<<< HEAD
#line 134 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 128 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\n    <td>\n        <button class=\"btn btn-primary btn-sm\">Edit</button>\n        <button class=\"btn btn-danger btn-sm\">Delete</button>\n    </td>\n</tr>            ");
#nullable restore
<<<<<<< HEAD
#line 140 "C:\Users\LENOVA\Downloads\ECWebApp-main\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
=======
#line 134 "C:\Users\msdemir\Downloads\ECWebApp-main (1)\ECWebApp-main\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n    <div class=\"card-footer\">\n        ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52845172cc3909e2baaae36e353334ba4a9c7d7617906", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81a7fadf3d50d5e2a1e11d36de949018a468623a14803", async() => {
>>>>>>> b4d56fb6abf958b8a9c51aa8ffe4ebedabb223c5
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
