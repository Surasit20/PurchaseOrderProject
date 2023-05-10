using Backend.Data;
using Microsoft.Extensions.Configuration;
using Shared;

namespace Backend.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;

        public OrderService(DataContext context)
        {
            _context = context;

        }

        public async Task<ServiceResponse<bool>> AddOrder(Order order)
        {

            try
            {
                _context.Orders.Add(order);
                var res = await _context.SaveChangesAsync();
                return new ServiceResponse<bool> { Data = true, Message = "Add new order successful!" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<bool> { Data = false, Message = ex.Message, Success=false };
            }

    
        }
    }
}
