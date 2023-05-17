using Azure.Core;
using Backend.Services.OrderService;
using Microsoft.AspNetCore.Mvc;
using Shared;
using System;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }


        // POST api/<OrderController>
        [HttpPost("add-order")]
        public async Task<ActionResult<ServiceResponse<int>>> AddOrder(Order order)
        {

            ServiceResponse<int> response  = await _orderService.AddOrder(order);
            if (!response.Success) 
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

    
        [HttpPost("add-order-item")]
        public async Task<ActionResult<ServiceResponse<int>>> AddOrderItems(List<OrderItem> orderItem)
        {

             await _orderService.AddOrderItems(orderItem);
          
            return Ok();
        }
        // GET: api/<OrderController>
        [HttpGet("product")]

        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {
            var response = await _orderService.GetProducts();
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
        [HttpGet("order/{orderId}")]

        public async Task<ActionResult<ServiceResponse<Order>>> GetOrder(int orderId)
        {
            var response = await _orderService.GetOrder(orderId);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpGet("order")]
        public async Task<ActionResult<ServiceResponse<List<Order>>>> GetOrders()
        {
            var response = await _orderService.GetOrders();
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }



        // PUT api/<OrderController>/5
        [HttpPut("order")]
        public async Task<ActionResult<ServiceResponse<Order>>> Put(Order order)
        {
            var response = await _orderService.EditOrder(order);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("order/{orderId}")]
        public async Task<ActionResult<ServiceResponse<Order>>> Delete(int orderId)
        {
            var response = await _orderService.DeleteOrder(orderId);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
