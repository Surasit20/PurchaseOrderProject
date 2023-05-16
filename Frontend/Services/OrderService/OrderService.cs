﻿using Shared;
using System.Net.Http;
using System.Net.Http.Json;

namespace Frontend.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _http;
        public OrderService(HttpClient http)
        {
            _http = http;
        }

        public List<OrderItem> orderItems { get; set; } = new List<OrderItem>();
        public List<Product> Products { get; set; } = new List<Product>();
      

        public async Task<int> AddOrder(Order order)
        {     

            var response = await _http.PostAsJsonAsync("api/Order/add-order",order);

            int newOrderId = (await response.Content
               .ReadFromJsonAsync<ServiceResponse<int>>()).Data;
            Console.WriteLine(newOrderId);
            //foreach (var item in orderItem)
            //{
              
            //      item.OrderId = newOrderId;
            //     orderItems.Add(new OrderItem {
            //     ProductId = item.ProductId,
            //     OrderId = newOrderId, 
            //     No=item.No,
            //     Quantity = item.Quantity,
            //     Price = item.Price,
            //     TotalPrice = item.TotalPrice

            //    });
            //}

          //    var responseOrderItem = await _http.PostAsJsonAsync("api/Order/add-order-item", orderItems);
            // Console.WriteLine(responseOrderItem);
            return newOrderId;


        }

        public async Task<Order> GetOrder(int orderID)
        {
            var response = new ServiceResponse<Order>();
            response = await _http.GetFromJsonAsync<ServiceResponse<Order>>($"api/Order/order/{orderID}");
            Console.WriteLine(response.Data);
            return response.Data;
        }

        public async Task<List<Product>> GetProducts()
        {
            var response = new ServiceResponse<List<Product>>();
            response = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Order/product");
            Console.WriteLine(response.Data);
            return response.Data;






        }
    }
}