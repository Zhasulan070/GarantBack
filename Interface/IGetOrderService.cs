using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;

namespace GarantsBack.Interface
{
    public interface IGetOrderService
    {
        public Task<List<Order>> CheckOrder(int userId);
    }
}