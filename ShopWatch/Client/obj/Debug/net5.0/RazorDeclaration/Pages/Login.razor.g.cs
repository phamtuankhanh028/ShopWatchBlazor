// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ShopWatch.Client.Pages
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
#nullable restore
#line 2 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Pages\Login.razor"
using ShopWatch.Client.Services.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Pages\Login.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\Admin\source\repos\ShopWatch\BlazorShopWatch\ShopWatch\Client\Pages\Login.razor"
       
     private LoginRequest loginRequest = new LoginRequest();

    private async Task Authenticate()
    {
        var loginResponse = await httpClient.PostAsJsonAsync<LoginRequest>("/api/Account/Login", loginRequest);

        if (loginResponse.IsSuccessStatusCode)
        {
            var userSession = await loginResponse.Content.ReadFromJsonAsync<UserSession>();
            var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
            await customAuthStateProvider.UpdateAuthenticationState(userSession);
            navManager.NavigateTo("/", true);
        }
        else if (loginResponse.StatusCode == HttpStatusCode.Unauthorized)
        {
            await js.InvokeVoidAsync("alert", "Invalid User Name or Password");
            return;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
