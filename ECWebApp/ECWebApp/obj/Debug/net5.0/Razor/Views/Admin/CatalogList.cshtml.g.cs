#pragma checksum "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e9ac499dd0a7110ce0362a94e2d3234a41b92ee"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e9ac499dd0a7110ce0362a94e2d3234a41b92ee", @"/Views/Admin/CatalogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df388a0c0a04755310f20216e0c9ff8d23653e73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_CatalogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CatalogListModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
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
#line 20 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 23 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
   Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 24 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9ac499dd0a7110ce0362a94e2d3234a41b92ee8522", async() => {
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
#line 26 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
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
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9ac499dd0a7110ce0362a94e2d3234a41b92ee11022", async() => {
                WriteLiteral("\n            <input type=\"hidden\" name=\"CategoryId\"");
                BeginWriteAttribute("value", " value=\"", 933, "\"", 957, 1);
#nullable restore
#line 30 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
WriteAttributeValue("", 941, item.CategoryId, 941, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </td>\n</tr>            ");
#nullable restore
#line 35 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n\n    <div class=\"card-footer\">\n        <button class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#addCategoryModal\">Create</button>\n\n        ");
#nullable restore
#line 43 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
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
#line 108 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <th>");
#nullable restore
#line 111 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e9ac499dd0a7110ce0362a94e2d3234a41b92ee16822", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3388, "~/images/products/tn/", 3388, 21, true);
#nullable restore
#line 113 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
AddHtmlAttributeValue("", 3409, item.Image, 3409, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </td>\n    <td>");
#nullable restore
#line 115 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n");
#nullable restore
#line 117 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
         if (item.IsApproved)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"check-square\"></span> ");
#nullable restore
#line 119 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
                                          }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"x-square\"></span>");
#nullable restore
#line 122 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\n    <td>\n");
#nullable restore
#line 125 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
         if (item.IsHome)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"check-square\"></span> ");
#nullable restore
#line 127 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
                                          }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"x-square\"></span>");
#nullable restore
#line 130 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\n    <td>\n");
#nullable restore
#line 133 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
         if (item.IsFeatured)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"check-square\"></span> ");
#nullable restore
#line 135 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
                                          }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span data-feather=\"x-square\"></span>");
#nullable restore
#line 138 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9ac499dd0a7110ce0362a94e2d3234a41b92ee21227", async() => {
                WriteLiteral("\n            Edit\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 141 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
                                                             WriteLiteral(item.ProductId);

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
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9ac499dd0a7110ce0362a94e2d3234a41b92ee23727", async() => {
                WriteLiteral("\n            <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 4321, "\"", 4344, 1);
#nullable restore
#line 145 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
WriteAttributeValue("", 4329, item.ProductId, 4329, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\n\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        \n    </td>\n</tr>            ");
#nullable restore
#line 151 "C:\Users\LENOVA\OneDrive\Masaüstü\ECWebApp\ECWebApp\Views\Admin\CatalogList.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </tbody>\n    </table>\n    <div class=\"card-footer\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9ac499dd0a7110ce0362a94e2d3234a41b92ee26507", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CatalogListModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
