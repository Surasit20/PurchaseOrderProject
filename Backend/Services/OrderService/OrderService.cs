﻿using Backend.Data;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ServiceResponse<int>> AddOrder(Order order)
        {

            try
            {

                order.SupplierId = 1;
                order.Id = 0;

                //List<OrderItem> orderItem = (List<OrderItem>)order.OrderItems;

                //order.OrderItems = null;
             

                 _context.Orders.Add(order);

                 await _context.SaveChangesAsync();

                //foreach (var i in orderItem)
                //{
                //    i.OrderId = order.Id;
                //    Console.WriteLine($"index:{i.No} {i.TotalPrice}  {i.ProductId} ");
                //}


                return new ServiceResponse<int> { Data = order.Id, Message = "Add new order successful!" };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new ServiceResponse<int> { Data = 0, Message = ex.Message, Success=false };
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
            List<Order> orderDetail = await _context.Orders
               .Where(c => c.Id == orderId)
               .Include(c => c.Supplier)
               .Include(c => c.OrderItems)        
               .ToListAsync();

            Console.WriteLine("=============================================================");
            foreach (var orderItem in orderDetail[0].OrderItems)
            {
                
                orderItem.Product = await _context.Products.FirstOrDefaultAsync(p=> p.Id == orderItem.ProductId);
                Console.WriteLine(orderItem.Product.Title);
            }
           
            return new ServiceResponse<Order> { Data = orderDetail[0], Message = "Get Order successful!" };
        }

        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {


            try
            {
                var products  = await _context.Products.ToListAsync();
            
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
                Console.WriteLine(order.Id);      
                var orderOld =  _context.Orders.FirstOrDefault(o => o.Id.Equals(order.Id));
                orderOld.TotalPrice = order.TotalPrice;
                orderOld.OrderDate = order.OrderDate;
                orderOld.OrderItems = order.OrderItems;
                orderOld.Purchaser = order.Purchaser;
                orderOld.Discount = order.Discount;
                orderOld.Status = order.Status;      
                orderOld.SupplierId = order.SupplierId;
                _context.Orders.Update(orderOld);
            

                await _context.SaveChangesAsync();




                return new ServiceResponse<Order> { Data = order, Message = "Add new order successful!" };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new ServiceResponse<Order> { Message = ex.Message, Success = false };
            }
        }

        public async Task<ServiceResponse<List<Order>>> GetOrders()
        {
            try
            {
                List<Order> orders = await _context.Orders.ToListAsync();

                foreach (Order order in orders)
                {
                    Supplier supplier = await _context.Suppliers.FirstOrDefaultAsync(p => p.Id == order.SupplierId);
                    order.Supplier = supplier;


                }

                return new ServiceResponse<List<Order>> { Data = orders, Message = "Get Orsers successful!" };
            }
            catch (Exception ex)
            {
                return new ServiceResponse<List<Order>> { Data = null, Message = ex.Message, Success = false };
            }
        }
    }
}
