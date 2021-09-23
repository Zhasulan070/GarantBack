using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;

namespace GarantsBack.Interface
{
    public interface IOrderService
    {
        public Task<string> CreateOrder(Order order);
        public Task<List<OrderModel>> GetOrdersById(string userId, string positionId);
        public Task<Order> GetOrderByUserIdAndOrderId(string userId, string orderId);
    }
}