using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Interface;

namespace GarantsBack.Service
{
    public class GetOrderService : IGetOrderService
    {
        public Task<List<Order>> CheckOrder(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}