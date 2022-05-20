using ShopWatch.Shared;
using Stripe.Checkout;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        Task<ServiceResponse<bool>> AddOrder(List<CartItem> cartItems);
    }
}
