using Shared;

namespace Frontend.Services.OrderService
{
    public class OrderService:IOrderService
    {
        private readonly HttpClient _http;
        public OrderService(HttpClient http)
        {
            _http = http;
        }

        public List<OrderItem> orderItem { get; set; } = new List<OrderItem>();

    
    }


}
