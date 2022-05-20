using Microsoft.AspNetCore.Components.Authorization;
using ShopWatch.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShopWatch.Client.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient _http;
        private readonly AuthenticationStateProvider _authStateProvider;

        public PaymentService(HttpClient http, AuthenticationStateProvider authStateProvider)
        {
            _http = http;
            _authStateProvider = authStateProvider;
        }

        public async Task<bool> AddOrder(List<CartItem> cartProducts)
        {
            var result = await _http.PostAsJsonAsync("api/Payment", cartProducts);
            return result.Content.ReadFromJsonAsync<ServiceResponse<bool>>().Result.Data;
        }
        
    }
}
