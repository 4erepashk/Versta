#pragma checksum "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0b383f5acf4b2c9d2cdf0d35cf8fa5529ab474f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Get), @"mvc.1.0.view", @"/Views/Order/Get.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0b383f5acf4b2c9d2cdf0d35cf8fa5529ab474f", @"/Views/Order/Get.cshtml")]
    public class Views_Order_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<versApp.Date.Models.Order>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
  
    ViewData["Title"] = "Get";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!DOCTYPE html>
<style>
    table {
        width: 90%;
        border-collapse: collapse;
        margin-left:auto;
        margin-right:auto;
        margin-top:100px;
    }

    thead {
        background: #c4c1c1;
        text-align: center;
    }

    tbody {
        background: #fff;
        text-align:center;
    }
    th, td {
        padding: 5px;
        border: 1px solid #333;
    }

    
    #navbar {
        margin: 0;
        padding: 0;
        list-style-type: none;
        border-bottom: 2px solid #000;
        width: 100%;
        text-align: left;
        background-color: #ffffff;
    }

        #navbar a {
            color: #000;
            padding: 5px 10px;
            text-decoration: none;
            font-weight: bold;
            display: inline-block;
            width: 100px;
        }

            #navbar a:hover {
                background-color: #F5F5F5;
            }
</style>

<html>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0b383f5acf4b2c9d2cdf0d35cf8fa5529ab474f3887", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>All orders</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0b383f5acf4b2c9d2cdf0d35cf8fa5529ab474f4951", async() => {
                WriteLiteral("\r\n    <ul id=\"navbar\">\r\n        ");
#nullable restore
#line 62 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
   Write(Html.ActionLink("Добавить новый заказ", "Create", "Order"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 63 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
   Write(Html.ActionLink("Просмотр всех заказов", "Get", "Order"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </ul>
    

    <form asp-controller=""order"" asp-action=""get"" method=""get"">

        <table class=""table"">
            <thead>
                <tr><th>Город отправителя</th><th>Адрес отправителя</th><th>Город получателя</th><th>Адрес получателя</th><th>Вес груза(кг)</th><th>Дата забора груза</th></tr>
            </thead>
            <tbody>
");
#nullable restore
#line 74 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 77 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
                       Write(item.CitySender);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 78 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
                       Write(item.AddressSender);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 79 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
                       Write(item.CityRecipient);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 80 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
                       Write(item.AddressRecipient);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 81 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
                       Write(item.Weigth);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 82 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
                       Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 84 "C:\Users\lolop\OneDrive\Рабочий стол\rep\versApp\versApp\Views\Order\Get.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </form>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<versApp.Date.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
