#pragma checksum "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f535dce10c4a36a438a885a461b14b7252ff85f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f535dce10c4a36a438a885a461b14b7252ff85f", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8998d1085e5ead66cf15cdd847e6ad6f068181da", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""content"">

    <!-- shop section start -->
    <section id=""shop"" class=""container"">

        <!-- row start -->
        <div class=""row"">

            <!-- sidebar start -->
            <div id=""sidebar"" class=""col-md-3"">

                <!-- search widget start -->
                <div class=""widget"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f535dce10c4a36a438a885a461b14b7252ff85f5333", async() => {
                WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control input-lg"" placeholder=""Search..."">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default btn-lg"" type=""submit""><i class=""fa fa-search""></i></button>
                            </span>
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
            WriteLiteral("\r\n                </div>\r\n                <!-- search widget end -->\r\n                <!-- categories widget start -->\r\n                ");
#nullable restore
#line 30 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
           Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <!-- categories widget end -->\r\n                <!-- featured products widget start -->\r\n                ");
#nullable restore
#line 33 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
           Write(await Component.InvokeAsync("FeaturedProducts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <!-- featured products widget end -->

            </div>
            <!-- sidebar end -->
            <!-- main column start -->
            <div class=""col-md-9"">

                <div class=""row"">


                    <!-- product page top info start -->
                    <div class=""col-md-12 product"">
                        <div class=""row"">
                            <div class=""col-md-6"">

                                <div id=""product-gallery"" class=""owl-carousel owl-theme"" style=""opacity: 1; display: block;"">
");
#nullable restore
#line 50 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                                     foreach (var img in Model.Product.Images)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"item\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f535dce10c4a36a438a885a461b14b7252ff85f8863", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2066, "~/images/products/", 2066, 18, true);
#nullable restore
#line 53 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 2084, img.ImageName, 2084, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 55 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                                </div>\r\n\r\n                                <div class=\"col-md-6\">\r\n\r\n                                    <div class=\"padding15\">\r\n                                        <h2 class=\"product-title\"><b>");
#nullable restore
#line 67 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                                                                Write(Model.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h2>
                                        <p>
                                            <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                            3 Reviews
                                        </p>

                                    </div>
                                    <p>");
#nullable restore
#line 74 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                                  Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n\r\n                                    <div class=\"padding15\">\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f535dce10c4a36a438a885a461b14b7252ff85f12164", async() => {
                WriteLiteral(@"
                                            <div class=""form-group qty"">
                                                <div class=""input-group"">
                                                    <span class=""input-group-addon"">Qty</span>
                                                    <input type=""number"" size=""4"" class=""form-control"" value=""1"" min=""1"" step=""1"">
                                                </div>
                                            </div>
                                            <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-cart-plus fa-fw""></i> Add to cart</button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </div>\r\n\r\n                                    <p><b>Category:</b> \r\n");
#nullable restore
#line 93 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                                     foreach (var item in Model.Categories)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a href=\"#\">");
#nullable restore
#line 95 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 96 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </p>

                                </div>
                            </div>
                        </div>
                        <!-- product page top info end -->
                        <!-- product page middle info start -->
                        <div class=""col-md-12 padding25"">


                            <ul class=""nav nav-tabs"">
                                <li class=""active""><a data-toggle=""tab"" href=""#description"">Description</a></li>
                                <li><a data-toggle=""tab"" href=""#spec"">Specifications</a></li>
                                <li><a data-toggle=""tab"" href=""#reviews"">Reviews (3)</a></li>
                            </ul>


                            <div class=""tab-content"">

                                <!-- description tab start -->
                                <div id=""description"" class=""tab-pane fade in active"">
                                   ");
#nullable restore
#line 118 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                              Write(Html.Raw(Model.Product.HtmlContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <!-- description tab end -->
                                <!-- Specifications tab start -->
                                <div id=""spec"" class=""tab-pane fade"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-striped table-hover"">
                                            <tbody>
");
#nullable restore
#line 126 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                                                 foreach (var item in Model.ProductAttributes)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td><b>");
#nullable restore
#line 129 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                                                          Write(item.Attribute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                                                        <td>");
#nullable restore
#line 130 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                                                       Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 132 "C:\Users\LENOVA\source\repos\ECWebApp\ECWebApp\Views\Product\Details.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <!-- Specifications tab end -->
                                <!-- reviews tab start -->
                                <div id=""reviews"" class=""tab-pane fade"">

                                    <div class=""reviews-list"">

                                        <div class=""media"">

                                            <a class=""media-left"" href=""#"">
                                                <img");
            BeginWriteAttribute("alt", " alt=\"", 6686, "\"", 6692, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle avatar"" src=""images/team/thumb8_40.jpg"">
                                            </a>
                                            <div class=""media-body"">
                                                <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small></p>
                                                <h4 class=""media-heading"">John Doe <small>2 days ago</small></h4>
                                                At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.
                                            </div>
                                        </div>

                                        <div class=""media"">
            WriteLiteral("\n\r\n                                            <a class=\"media-left\" href=\"#\">\r\n                                                <img");
            BeginWriteAttribute("alt", " alt=\"", 7849, "\"", 7855, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle avatar"" src=""images/team/thumb5_40.jpg"">
                                            </a>
                                            <div class=""media-body"">
                                                <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small></p>
                                                <h4 class=""media-heading"">Sarah Smith<small>4 days ago</small></h4>
                                                Nunc risus ex, tempus quis purus ac, tempor consequat ex. Vivamus sem magna, maximus at est id, maximus aliquet nunc. Suspendisse lacinia velit a eros porttitor, in interdum ante faucibus.
                                            </div>
                                        </div>

                                        <div class=""media"">

                                            <a class=""media-left"" href=""#"">
                         ");
            WriteLiteral("                       <img");
            BeginWriteAttribute("alt", " alt=\"", 8907, "\"", 8913, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-circle avatar"" src=""images/team/thumb3_40.jpg"">
                                            </a>
                                            <div class=""media-body"">
                                                <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small></p>
                                                <h4 class=""media-heading"">Jane Doe<small>5 days ago</small></h4>
                                                Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.
                                            </div>
                                        </div>

                                    </div>

                                    <div class=""page-header"">
                                        <h4>ADD A <b>REVIEW</b></h4>
                         ");
            WriteLiteral("           </div>\r\n\r\n                                    <p class=\"text-muted\">You must be logged in to add a review.</p>\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f535dce10c4a36a438a885a461b14b7252ff85f23112", async() => {
                WriteLiteral(@"
                                        <div class=""row"">
                                            <div class=""form-group col-xs-6"">
                                                <input type=""text"" class=""form-control input-lg"" placeholder=""Name*""");
                BeginWriteAttribute("required", " required=\"", 10361, "\"", 10372, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            </div>\r\n                                            <div class=\"form-group col-xs-6\">\r\n                                                <input type=\"email\" class=\"form-control input-lg\" placeholder=\"Email*\"");
                BeginWriteAttribute("required", " required=\"", 10625, "\"", 10636, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            </div>\r\n\r\n                                            <div class=\"form-group col-xs-12\">\r\n                                                <textarea class=\"form-control\" rows=\"6\" placeholder=\"Review*\"");
                BeginWriteAttribute("required", " required=\"", 10883, "\"", 10894, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                                            </div>

                                            <div class=""form-group col-xs-12 text-right"">
                                                <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-check fa-fw""></i> SUBMIT REVIEW</button>
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                </div>
                                <!-- reviews tab end -->

                            </div>

                        </div>
                     

                    </div>
                    <!-- row end -->

                </div>
                <!-- main column end -->

            </div>
            <!-- row end -->

    </section>
    <!-- shop section end -->

</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591