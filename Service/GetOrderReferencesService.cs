using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Helpers;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.Extensions.Configuration;

namespace GarantsBack.Service
{
    public class GetOrderReferencesService : IGetOrderReferencesService
    {
        private readonly string _getOrderTypeList;

        public GetOrderReferencesService(IConfiguration iConfig)
        {
            var servicesUrl = iConfig.GetSection("OFServices").GetSection("Url").Value;
            _getOrderTypeList = servicesUrl + iConfig.GetSection("OFServices").GetSection("GetInitReferences").Value;

        }

        public async Task<OrderReferences> GetList()
        {
            var filials = await RequestHelper.SendGetRequestAsync<OrderReferences>(_getOrderTypeList);
            return filials;
        }
    }
}