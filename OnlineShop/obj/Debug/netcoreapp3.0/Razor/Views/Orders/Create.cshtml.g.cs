#pragma checksum "C:\Users\гороховв\Source\Repos\VladislavG123\OnlineShopTemplate2.0\OnlineShop\Views\Orders\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aba055a2fb126b08257f50437cf20c0751372e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Create), @"mvc.1.0.view", @"/Views/Orders/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aba055a2fb126b08257f50437cf20c0751372e8", @"/Views/Orders/Create.cshtml")]
    public class Views_Orders_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShop.Domain.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\гороховв\Source\Repos\VladislavG123\OnlineShopTemplate2.0\OnlineShop\Views\Orders\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Order</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""IsPayed"" /> ");
#nullable restore
#line 17 "C:\Users\гороховв\Source\Repos\VladislavG123\OnlineShopTemplate2.0\OnlineShop\Views\Orders\Create.cshtml"
                                                                    Write(Html.DisplayNameFor(model => model.IsPayed));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""PaymentUrl"" class=""control-label""></label>
                <input asp-for=""PaymentUrl"" class=""form-control"" />
                <span asp-validation-for=""PaymentUrl"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DeliveryAddress"" class=""control-label""></label>
                <input asp-for=""DeliveryAddress"" class=""form-control"" />
                <span asp-validation-for=""DeliveryAddress"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OrderStatus"" class=""control-label""></label>
                <select asp-for=""OrderStatus"" class=""form-control""></select>
                <span asp-validation-for=""OrderStatus"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreationDate"" class=""c");
            WriteLiteral(@"ontrol-label""></label>
                <input asp-for=""CreationDate"" class=""form-control"" />
                <span asp-validation-for=""CreationDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DeletedDate"" class=""control-label""></label>
                <input asp-for=""DeletedDate"" class=""form-control"" />
                <span asp-validation-for=""DeletedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShop.Domain.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
