using ShopWatch.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShopWatch.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {

        private readonly HttpClient _http;
        public List<Category> Categories { get; set; } = new List<Category>();

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadCategories()
        {
            Categories = await _http.GetFromJsonAsync<List<Category>>("api/Category");
                
                /*new List<Category>
                 {
                new Category { Id=1, Name="Seiko", Url="seiko", Icon="Seiko" },
                new Category { Id=2, Name="Rolex", Url="rolex", Icon="Rolex" },
                new Category { Id=3, Name="Longiness", Url="longiness", Icon="Longginess" },
                };*/
        }



        public async Task<bool> AddCategory(Category category)
        {
            var response = await _http.PostAsJsonAsync("api/Category/admin/category/add", category);
            var result = (await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>()).Data;
            return result;
        }
        public async Task<bool> UpdateCategory(Category category)
        {
            var response = await _http.PutAsJsonAsync("api/Category/admin/category/update", category);
            var result = (await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>()).Data;
            return result;
        }
        public async Task<Category> GetCategoryById(int id)
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<Category>>($"api/Category/{id}");
            return response.Data;
        }
        public async Task<bool> DeleteCategory(int id)
        {
            var response = await _http.DeleteAsync($"api/Category/admin/{id}");
            return (await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>()).Data;
        }
    }
}
