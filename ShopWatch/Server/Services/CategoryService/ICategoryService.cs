using ShopWatch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryUrl);

        Task<ServiceResponse<bool>> AddCategory(Category category);
        Task<ServiceResponse<bool>> UpdateCategory(Category category);
        Task<ServiceResponse<Category>> GetCategoryById(int id);
        Task<ServiceResponse<bool>> DeleteCategory(int id);
    }
}
