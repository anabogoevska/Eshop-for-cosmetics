#pragma checksum "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c469756ba9d534536b2896216d91215a9e621fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\_ViewImports.cshtml"
using EShop.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c469756ba9d534536b2896216d91215a9e621fe", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc86adf4195d4512c16f46bcb0c238cc76dc7280", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShop.Domain.DomainModels.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddProductToCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 45px; width: 190px; margin-left: -203px; margin-top: 32px; border-radius: 0px; background-color: #6BCFDF; border-color: #6BCFDF;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n\r\n    <hr />\r\n\r\n\r\n    <div class=\"col\"");
            BeginWriteAttribute("style", " style=\"", 1669, "\"", 1677, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 1693, "\"", 1718, 1);
#nullable restore
#line 58 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"
WriteAttributeValue("", 1699, Model.ProductImage, 1699, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" style=\"margin-left: -90px; height: 400px; width: 400px;\">\r\n    </div>\r\n\r\n    <div class=\"col\" style=\"margin-left: 350px; margin-top: -355px;\">\r\n\r\n        <h2><b> ");
#nullable restore
#line 63 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>  </h2>\r\n\r\n\r\n\r\n\r\n        <dd>\r\n            <p style=\"font-size: 29px; margin-right: 25px; font-family: Brush Script MT, Brush Script Std, cursive;\"><i> ");
#nullable restore
#line 69 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"
                                                                                                                    Write(Html.DisplayFor(model => model.ProductDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n\r\n        </dd>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 76 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"
          


            if (Model.Rating == 5)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <img src=\"https://static.thenounproject.com/png/1143722-200.png\" width=\"200px\" height=\"188px\" style=\"margin-top: -44px; margin-left: -12px;\">\r\n");
#nullable restore
#line 83 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"

            }

            if (Model.Rating == 4)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <img src=\"https://static.thenounproject.com/png/1149720-200.png\" width=\"160px\" height=\"148px\" style=\"margin-top: -44px; margin-left: -12px;\">\r\n");
#nullable restore
#line 90 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"

            }

            if (Model.Rating == 3)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <img src=\"https://static.thenounproject.com/png/1149721-200.png\" width=\"180px\" height=\"168px\" style=\"margin-top: -44px; margin-left: -12px;\">\r\n");
#nullable restore
#line 98 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"

            }

            if (Model.Rating == 2)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <img src=\"https://static.thenounproject.com/png/2554122-200.png\" width=\"120px\" height=\"118px\" style=\"margin-top: -44px; margin-left: -8px;\">\r\n");
#nullable restore
#line 105 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"

            }

            if (Model.Rating == 1)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <img src=\"https://static.thenounproject.com/png/2155113-200.png\" width=\"160px\" height=\"148px\" style=\"margin-top: -44px; margin-left: -12px;\" />\r\n");
#nullable restore
#line 112 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"

            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div style=\"margin-top: -30px;\">\r\n            <dd>\r\n                <h4><b>$");
#nullable restore
#line 118 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"
                   Write(Html.DisplayFor(model => model.ProductPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n            </dd>\r\n\r\n            <dd>\r\n                <h4><b>");
#nullable restore
#line 122 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"
                  Write(Html.DisplayFor(model => model.ProductQuantity));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" g</b></h4>

            </dd>

            <dd>

                <a class=""btn btn-info text-center"" style=""height: 45px; width: 190px;  margin-top: 49px;  border-radius: 0px; background-color: #F5EA77; border-color: #F5EA77; "">
                    <h5 style=""margin-left: -35px; font-size: 17px; margin-left: -4px; margin-top: 4px;""> </h5>

                </a>

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c469756ba9d534536b2896216d91215a9e621fe10135", async() => {
                WriteLiteral("\r\n                    <h5 style=\"margin-left: -35px; font-size: 17px; margin-left: -4px; margin-top: 4px;\"> Add to card $");
#nullable restore
#line 134 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"
                                                                                                                  Write(Model.ProductPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                ");
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
#line 133 "C:\Users\USER\OneDrive\Desktop\EShopApplication\EShopApplication\EShop.Web\Views\Products\Details.cshtml"
                                                                             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </dd>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShop.Domain.DomainModels.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
