using ShopWatch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Client.Services.PaymentService
{
    public interface IPaymentService
    {
        Task<bool> AddOrder(List<CartItem> cartProducts);
    }
}
