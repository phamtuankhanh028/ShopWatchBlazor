using Microsoft.EntityFrameworkCore;
using ShopWatch.Server.Data;
using ShopWatch.Server.Services.CategoryService;
using ShopWatch.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWatch.Server.Services.ProductService
{
    public class ProductService : IProductService
    {


        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {
            _categoryService = categoryService;
            _context = context;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products
                .Where(p => p.Category.IsDelete == false && p.IsDeleted == false)
                .Include(p => p.Variants)
                .ThenInclude(v=> v.Edition)
                .ToListAsync();
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Include(p => p.Variants).Where(p => p.CategoryId == category.Id).ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.Edition)
                .FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> SearchProducts(string searchText)
        {
            return await _context.Products
                                .Where(p => p.Title.Contains(searchText) ||
                                    p.Description.Contains(searchText))
                                .ToListAsync();
        }

        public async Task<List<Product>> GetAdminProducts()
        {
           
            return await _context.Products.Include(p=>p.Variants).ThenInclude(v => v.Edition).ToListAsync();
        }
        public async Task<ServiceResponse<bool>> AddProduct(Product product)
        {
            if (product == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    Success = false,
                    Message = "Product is null"
                };
            }
            product.DateCreated = System.DateTime.Now;
            var result = await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool> { Data = true, Success = true, Message = "Add product is success" };
        }
        public async Task<ServiceResponse<bool>> UpdateProduct(Product product)
        {
            var response = await _context.Products.FindAsync(product.Id);
            if (product == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    Success = false,
                    Message = "Product is null"
                };
            }
            if (response == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    Success = false,
                    Message = "Product not found"
                };
            }
            /*_context.Products.UpdateRange(product);*/
            response.Title = product.Title;
            response.Description = product.Description;
            response.DateUpdated = System.DateTime.Now;
            response.IsPublic = product.IsPublic;
            response.Image = product.Image;
            foreach (var variant in product.Variants)
            {
                var dbVariant = await _context.ProductVariants
                    .SingleOrDefaultAsync(v => v.ProductId == variant.ProductId &&
                        v.EditionId == variant.EditionId);
                if (dbVariant == null)
                {
                    variant.Edition = null;
                    _context.ProductVariants.Add(variant);
                }
                else
                {
                    dbVariant.EditionId = variant.EditionId;
                    dbVariant.Price = variant.Price;
                    dbVariant.OriginalPrice = variant.OriginalPrice;
                }
            }

            await _context.SaveChangesAsync();
            return new ServiceResponse<bool> { Data = true, Success = true, Message = "Update product is success" };
        }
        public async Task<ServiceResponse<bool>> DeleteProduct(int id)
        {
            var response = await _context.Products.FindAsync(id);
            if (response == null)
            {
                return new ServiceResponse<bool>
                {
                    Data = false,
                    Success = false,
                    Message = "Product not found"
                };
            }
            response.IsDeleted = true;
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool>
            {
                Data = true,
                Success = true,
                Message = "Product has been deleted"
            };
        }
    }
}
