using Shared;

namespace Backend.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<int>>  AddOrder(Order order);
        Task<ServiceResponse<Order>> GetOrder(int orderId);
        Task  AddOrderItems(List<OrderItem> orderItem);
        Task<ServiceResponse<List<Product>>> GetProducts();
      
    }
}
