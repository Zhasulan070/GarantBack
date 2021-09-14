using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;

namespace GarantsBack.Interface
{
    public interface IGetOrderReferencesService
    {
        public Task<OrderReferences> GetList();
    }
}