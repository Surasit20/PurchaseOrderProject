using Shared;

namespace Backend.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<int>> AddOrder(Order order);
        Task<ServiceResponse<Order>> EditOrder(Order order);
        Task<ServiceResponse<Order>> GetOrder(int orderId);
        Task<ServiceResponse<List<OrderDto>>> GetOrders();
        Task AddOrderItems(List<OrderItem> orderItem);
        Task<ServiceResponse<List<Product>>> GetProducts();
        Task<ServiceResponse<Order>> DeleteOrder(int orderId);

    }
}
