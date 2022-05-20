﻿using ShopWatch.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShopWatch.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action Onchange;

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadProducts(string categoryUrl = null)
        {
            if (categoryUrl == null)
            {
                Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product");
            }
            else
            {
                Products = await _http.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
            }
            Onchange.Invoke();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _http.GetFromJsonAsync<Product>($"api/Product/{id}");
        }

        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _http.GetFromJsonAsync<List<Product>>($"api/Product/Search/{searchText}");
        }


        //-------Admin-------//
        public async Task<List<Product>> GetAdminProducts()
        {
            return await _http.GetFromJsonAsync<List<Product>>("api/Product/Admin");
           
        }

        public async Task<ServiceResponse<bool>> AddProduct(Product product)
        {
            var response = await _http.PostAsJsonAsync("api/Product", product);
            return await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }
        public async Task<ServiceResponse<bool>> UpdateProduct(Product product)
        {
            var response = await _http.PutAsJsonAsync($"api/Product/admin/{product.Id}", product);
            return await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }
        public async Task<ServiceResponse<bool>> DeleteProduct(int id)
        {
            var response = await _http.DeleteAsync($"api/Product/admin/{id}");
            return await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }
    }
}
