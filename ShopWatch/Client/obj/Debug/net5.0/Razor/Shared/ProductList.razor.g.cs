#pragma checksum "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Shared\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89b98ac18d6350f334b827710709155900c2a70"
// <auto-generated/>
#pragma warning disable 1591
namespace ShopWatch.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using ShopWatch.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using ShopWatch.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using ShopWatch.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using ShopWatch.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using ShopWatch.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using ShopWatch.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using ShopWatch.Client.Services.EditionService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using ShopWatch.Client.Services.PaymentService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "product spad");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-12 col-md-12");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
#nullable restore
#line 11 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Shared\ProductList.razor"
                     foreach (var product in ProductService.Products)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-lg-4 col-md-6 col-sm-6");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "product__item");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "product__item__pic set-bg");
            __builder.AddAttribute(16, "style", "background-image:" + " url(" + (
#nullable restore
#line 15 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Shared\ProductList.razor"
                                                                                                     product.Image

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "product__item__pic__hover");
            __builder.OpenElement(19, "li");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/product/" + (
#nullable restore
#line 17 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Shared\ProductList.razor"
                                                               product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<i class=\"fa fa-shopping-cart\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "product__discount__item__text");
            __builder.OpenElement(26, "h5");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "/product/" + (
#nullable restore
#line 22 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Shared\ProductList.razor"
                                                           product.Id

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 22 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Shared\ProductList.razor"
__builder.AddContent(29, product.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "product__item__price");
#nullable restore
#line 23 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Shared\ProductList.razor"
__builder.AddContent(33, GetPriceText(product));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Shared\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Shared\ProductList.razor"
       
    //[Parameter]
    //public int? CategoryId { get; set; } = null;

    protected override void OnInitialized()
    {
        // await ProductService.LoadProducts();
        ProductService.Onchange += StateHasChanged;
    }

    public void Dispose()
    {
        ProductService.Onchange -= StateHasChanged;
    }

    private string GetPriceText(Product product)
    {
        var variants = product.Variants;
        if(variants.Count == 0)
        {
            return string.Empty;
        }else if(variants.Count ==1)
        {
            return $"{variants[0].Price :C0}";
        }
        decimal minPrice = variants.Min(v => v.Price);
        return $"Gi?? t??? {minPrice :C0}";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
