using ShopWatch.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action Onchange;
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl = null);

        Task<Product>  GetProduct(int id);

        Task<List<Product>> SearchProducts(string searchText);


        //----------------Admin------------------------//
        Task<List<Product>> GetAdminProducts();
        Task<ServiceResponse<bool>> AddProduct(Product product);
        Task<ServiceResponse<bool>> UpdateProduct(Product product);
        Task<ServiceResponse<bool>> DeleteProduct(int id);
    }
}
