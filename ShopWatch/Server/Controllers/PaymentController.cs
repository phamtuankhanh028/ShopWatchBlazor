using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopWatch.Server.Services.PaymentService;
using ShopWatch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<bool>>> AddOrder(List<CartItem> cartItems)
        {
            return Ok( await _paymentService.AddOrder(cartItems));
        }
    }
}
