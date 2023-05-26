using AutoMapper;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shared;

namespace Backend.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public OrderService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }

        public async Task<ServiceResponse<int>> AddOrder(Order order)
        {

            try
            {

                order.SupplierId = 1;
                order.Id = 0;
                _context.Orders.Add(order);

                await _context.SaveChangesAsync();


                return new ServiceResponse<int> { Data = order.Id, Message = "Add new order successful!" };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new ServiceResponse<int> { Data = 0, Message = ex.Message, Success = false };
            }


        }

        public async Task AddOrderItems(List<OrderItem> orderItem)
        {
            Console.WriteLine(orderItem.Count);
            Console.WriteLine("Start.... Add OrderItem");
            foreach (var item in orderItem)
            {
                item.Id = 0;
                Console.WriteLine($"{item.ProductId}");
                _context.OrderItems.Add(item);
                await _context.SaveChangesAsync();
            }


        }

        public async Task<ServiceResponse<Order>> GetOrder(int orderId)
        {
            Order orderDetail = await _context.Orders
                           .Include(c => c.Supplier)
                           .Include(c => c.OrderItems)
                           .ThenInclude(c => c.Product)
                           .FirstOrDefaultAsync(o => o.Id == orderId);


            foreach (var orderItem in orderDetail.OrderItems)
            {

                orderItem.Product = await _context.Products.FirstOrDefaultAsync(p => p.Id == orderItem.ProductId);
                Console.WriteLine(orderItem.Product.Title);
            }

            return new ServiceResponse<Order> { Data = orderDetail, Message = "Get Order successful!" };
        }

        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {


            try
            {
                var products = await _context.Products.ToListAsync();

                return new ServiceResponse<List<Product>> { Data = products, Message = "Get Products successful!" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<Product>> { Message = ex.Message, Success = false };
            }

        }

        public async Task<ServiceResponse<Order>> DeleteOrder(int orderId)
        {
            try
            {
                Order order = new Order() { Id = orderId };
                _context.Orders.RemoveRange(order);
                await _context.SaveChangesAsync();
                return new ServiceResponse<Order> { Data = order, Message = "Delete Orser successful!" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<Order> { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse<Order>> EditOrder(Order order)
        {
            try
            {
                var orderOld = _context.Orders.FirstOrDefault(o => o.Id.Equals(order.Id));
                orderOld.TotalPrice = order.TotalPrice;
                orderOld.OrderDate = order.OrderDate;
                orderOld.OrderItems = order.OrderItems;
                orderOld.Purchaser = order.Purchaser;
                orderOld.Discount = order.Discount;
                orderOld.Status = order.Status;
                orderOld.SupplierId = order.SupplierId;
                _context.Orders.Update(orderOld);

                await _context.SaveChangesAsync();
                return new ServiceResponse<Order> { Data = order, Message = "Edit new order successful!" };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new ServiceResponse<Order> { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse<List<OrderDto>>> GetOrders()
        {
            try
            {
                var orders = await _context.Orders
                    .Include(o => o.Supplier)
                    .ToListAsync();

                List<OrderDto> orderDto = _mapper.Map<List<OrderDto>>(orders);


                return new ServiceResponse<List<OrderDto>> { Data = orderDto, Message = "Get Orsers successful!" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<OrderDto>> { Data = null, Message = ex.Message, Success = false };
            }
        }
    }
}
