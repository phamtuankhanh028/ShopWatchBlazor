using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using ShopWatch.Server.Data;
using ShopWatch.Shared;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ShopWatch.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly DataContext _context;

        public PaymentService(DataContext context)
        {
            _context = context;
        }

        /*private readonly IHttpContextAccessor _httpContextAccessor;*/


        public async Task<ServiceResponse<bool>> AddOrder(List<CartItem> cartItems)
        {
            decimal totalPrice = 0;
            /*var userId = _authService.GetUserId();*/
            /*var id = int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));*/
            cartItems.ForEach(product => totalPrice += product.Price * product.Quantity);

            var orderItems = new List<OrderItem>();
            cartItems.ForEach(product => orderItems.Add(new OrderItem
            {
                ProductId = product.ProductId,
                EditionId = product.EditionId,
                Quantity = product.Quantity,
                TotalPrice = product.Price * product.Quantity
            }));
            var order = new Order
            {
                UserId = 2,
                OrderDate = DateTime.Now,
                TotalPrice = totalPrice,
                OrderItems = orderItems
            };

            _context.Orders.Add(order);
            /*_context.CartItems.RemoveRange(_context.CartItems
                .Where(ci => ci.UserId == userId));*/
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool> { Data = true };
        }
    }
}
