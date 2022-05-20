
using Microsoft.EntityFrameworkCore;
using ShopWatch.Server.Data;
using ShopWatch.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWatch.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategories()
        {

            return await _context.Categories
                .Where(c => c.IsDelete == false)
                .ToListAsync();
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }

        public async Task<ServiceResponse<bool>> AddCategory(Category category)
        {
            var result = _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            if (result == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                };
            }
            return new ServiceResponse<bool>
            {
                Data = true,
            };
        }

        public async Task<ServiceResponse<Category>> GetCategoryById(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return new ServiceResponse<Category>
                {
                    Success = false,
                    Message = "Category not fount"
                };
            }
            return new ServiceResponse<Category> { Data= category, Success = true };
        }

        public async Task<ServiceResponse<bool>> UpdateCategory(Category category)
        {
            var result = _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            if (result == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                };
            }
            return new ServiceResponse<bool>
            {
                Data = true,
            };
        }

        public async Task<ServiceResponse<bool>> DeleteCategory(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if (category == null)
            {
                return new ServiceResponse<bool> 
                { Data = false, 
                  Success = false , 
                  Message= "Category not fount"
                };
            }
            category.IsDelete = true;
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool>
            {
                Data = true,
                Success = true,
                Message = "Delete is success"
            };
        }
    }
}