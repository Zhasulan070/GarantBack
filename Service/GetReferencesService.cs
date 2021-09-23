using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Helpers;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.Extensions.Configuration;

namespace GarantsBack.Service
{
    public class GetReferencesService : IGetReferencesService
    {
        private readonly string _getReferencesService;

        public GetReferencesService(IConfiguration iConfig)
        {
            var servicesUrl = iConfig.GetSection("LocalServices").GetSection("Url").Value;
            _getReferencesService = servicesUrl + iConfig.GetSection("LocalServices").GetSection("GetReferencesService").Value;

        }

        public async Task<List<Filials>> GetFilials()
        {
            var filials = await RequestHelper.SendGetRequestAsync<Response<List<Filials>>>($"{_getReferencesService}/GetFilials");
            return filials.Result;
        }

        public async Task<List<Currencies>> GetCurrencies()
        {
            var currencies = await RequestHelper.SendGetRequestAsync<Response<List<Currencies>>>($"{_getReferencesService}/GetCurrencies");
            return currencies.Result;
        }

        public async Task<List<RequestTypes>> GetRequestTypes()
        {
            var requestTypes = await RequestHelper.SendGetRequestAsync<Response<List<RequestTypes>>>($"{_getReferencesService}/RequestTypes");
            return requestTypes.Result;
        }
        
        public async Task<List<Segments>> GetSegments()
        {
            var requestTypes = await RequestHelper.SendGetRequestAsync<Response<List<Segments>>>($"{_getReferencesService}/Segments");
            return requestTypes.Result;
        }
    }
}