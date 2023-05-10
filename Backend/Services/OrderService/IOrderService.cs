using Shared;

namespace Backend.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<bool>> AddOrder(Order order);
    }
}
