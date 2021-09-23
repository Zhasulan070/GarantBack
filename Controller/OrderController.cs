using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GarantsBack.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IOrderService _service;

        public OrderController(ILogger<OrderController> logger, IOrderService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("GetOrdersByUserId")]
        public async Task<IActionResult> GetOrdersById([FromQuery(Name = "userId")] string userId, [FromQuery(Name = "positionId")] string positionId)
        {
            var response = new Response<List<OrderModel>>();

            try
            {
                response.Result = await _service.GetOrdersById(userId, positionId);
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in GetOrdersById service";
                _logger.LogError(e, response.ErrorMessage);
            }
            
            return Ok(response);
        }
        
        [HttpGet("GetOrderByUserIdAndOrderId")]
        public async Task<IActionResult> GetOrderByUserIdAndOrderId([FromQuery(Name = "userId")] string userId, [FromQuery(Name = "orderId")] string orderId)
        {
            var response = new Response<Order>();

            try
            {
                response.Result = await _service.GetOrderByUserIdAndOrderId(userId, orderId);
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in GetOrdersById service";
                _logger.LogError(e, response.ErrorMessage);
            }
            
            return Ok(response);
        }
        
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
             var response = new Response<string>();

            try
            {
                response.Result = await _service.CreateOrder(order);
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in CreateOrder service";
                _logger.LogError(e, response.ErrorMessage);
            }
            
            return Ok(response);
        }
    }
}