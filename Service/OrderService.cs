using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Helpers;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace GarantsBack.Service
{
    public class OrderService : IOrderService
    {
        private readonly string _getOrderService;
        
        public OrderService(IConfiguration iConfig)
        {
            var servicesUrl = iConfig.GetSection("LocalServices").GetSection("Url").Value;
            _getOrderService = servicesUrl + iConfig.GetSection("LocalServices").GetSection("OrderService").Value;
        }
        public async Task<string> CreateOrder(Order order)
        {
            var resHttp = await RequestHelper.SendPostRequestAsync<Response<string>>($"{_getOrderService}/CreateOrder", order);
            return resHttp.Result;
        }

        public async Task<List<OrderModel>> GetOrdersById(string userId)
        {
            var resHttp = await RequestHelper.SendGetRequestAsync<Response<List<OrderModel>>>($"{_getOrderService}/GetOrder?userId={userId}");
            return resHttp.Result;
        }

        public async Task<Order> GetOrderByUserIdAndOrderId(string userId, string orderId)
        {
            var resHttp = await RequestHelper.SendGetRequestAsync<Response<Order>>($"{_getOrderService}/GetOrderByOrderId?userId=1&orderId=11796");
            return resHttp.Result;
        }
    }
}