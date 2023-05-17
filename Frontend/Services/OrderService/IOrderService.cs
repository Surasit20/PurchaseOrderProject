using Shared;

namespace Frontend.Services.OrderService
{
    public interface IOrderService
    {
        List<OrderItem> orderItems { get; set; }

        public Task<int> AddOrder(Order order);
        public Task<Order> EditOrder(Order order);
        public Task<Order> GetOrder(int orderId);
        public Task<List<Product>> GetProducts();
        public Task<List<Order>> GetOrders();
        public Task<Order> DeleteOrder(int orderId);
    }
}
