#pragma checksum "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63e86f3b3cbc281bc49aa8d055e6826b49583c60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 2 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63e86f3b3cbc281bc49aa8d055e6826b49583c60", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aaede9f30ca404cbb1bebdabb17a06cbc0a43c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
  
    var popularClass = Model.Products.Count > 2 ? "popular" : " ";
    var products = Model.Products;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 12 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 17 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
 if (products.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
                                          
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 25 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
         foreach (var product in products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 28 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
           Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 30 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 32 "D:\Sadık Turan\11-.NET CORE MVC\5-Form İle Çalışma\1_Arama Formu Get Method\ShopApp\ShopApp.WebUI\Views\Product\List.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
