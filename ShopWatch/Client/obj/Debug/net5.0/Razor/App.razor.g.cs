#pragma checksum "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e32d0477e8287d7650f70784dc35e3088efdd7e"
// <auto-generated/>
#pragma warning disable 1591
namespace ShopWatch.Client
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "PreferExactMatches", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(6);
                    __builder3.AddAttribute(7, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\App.razor"
                                        routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(9, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(10);
                    __builder3.AddAttribute(11, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 7 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
