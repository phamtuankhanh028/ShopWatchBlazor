using Blazored.LocalStorage;
using Blazored.Toast.Services;
using ShopWatch.Client.Services.ProductService;
using ShopWatch.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShopWatch.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;
        private readonly HttpClient _http;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, 
            IToastService toastService, 
            IProductService productService,
            HttpClient http)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
            _http = http;
        }

        public async Task AddToCart(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var sameItem = cart
                .Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            if (sameItem == null)
            {
                cart.Add(item);
            }
            else
            {
                sameItem.Quantity += item.Quantity;
            }
            
            await _localStorage.SetItemAsync("cart", cart);


            var product = await _productService.GetProduct(item.ProductId);
            _toastService.ShowSuccess(product.Title, "Đã thêm vào giỏ: ");

            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
              // tạo cái list danh sách sản phẩm 
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return new List<CartItem>();
            }
            return cart;

            /*foreach (var item in cart)   // lấy danh sách sản phẩm và đọc sản phẩm theo id r.
                                         // khi được sp có nghĩa là có những thuộc tính cartitem và đưa vào list
            {
                var product = await _productService.GetProduct(item.ProductId);
                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    ProductTitle = product.Title,
                    EditionId = item.EditionId,
                    Image = product.Image,
                     *EditName
                     * Price 
                     * Sẽ được lấy từ variant
                    
                };

            var variant = product.Variants.Find(v => v.EditionId == item.EditionId);
                if(variant != null)
                {
                    cartItem.EditName = variant.Edition?.Name;
                    cartItem.Price = variant.Price;
                }

                result.Add(cartItem);
            }
            return result;*/
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if(cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            cart.Remove(cartItem);
            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task EmptyCart()
        {
            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();
        }

        public async Task<string> Checkout()
        {
            var result = await _http.PostAsJsonAsync("api/payment/checkout", await GetCartItems());
            var url = await result.Content.ReadAsStringAsync();
            return url;
        }
    }
}
