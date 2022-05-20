using ShopWatch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }

        Task LoadCategories();
        Task<bool> UpdateCategory(Category category);
        Task<Category> GetCategoryById(int id);
        Task<bool> AddCategory(Category category);
        Task<bool> DeleteCategory(int id);
    }
}
