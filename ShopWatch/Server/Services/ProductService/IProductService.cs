using ShopWatch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<List<Product>> GetProductsByCategory(string categoryUrl);

        Task<Product> GetProduct(int id);

        Task<List<Product>> SearchProducts(string searchText);
        Task<ServiceResponse<bool>> AddProduct(Product product);
        Task<ServiceResponse<bool>> UpdateProduct(Product product);
        Task<ServiceResponse<bool>> DeleteProduct(int id);


        //----------Admin-----------//
        Task<List<Product>> GetAdminProducts();

    }
}
