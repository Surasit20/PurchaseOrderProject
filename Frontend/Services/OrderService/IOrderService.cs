using Shared;

namespace Frontend.Services.OrderService
{
    public interface IOrderService
    {
       List<OrderItem> orderItem { get; set; } 
    }
}
