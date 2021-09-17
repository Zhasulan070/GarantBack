using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Interface;
using Microsoft.Extensions.Configuration;
using GarantsBack.Helpers;
using GarantsBack.Model;

namespace GarantsBack.Service
{
    public class GetCheckersService : IGetCheckersService
    {
        private readonly string _getChekersService;
        
        public GetCheckersService(IConfiguration iConfig)
        {
            var servicesUrl = iConfig.GetSection("LocalServices").GetSection("Url").Value;
            _getChekersService = servicesUrl + iConfig.GetSection("LocalServices").GetSection("GetCheckersService").Value;

        }
        public async Task<List<Checkers>> GetCheckersList()
        {
            var resHttp = await RequestHelper.SendGetRequestAsync<Response<List<Checkers>>>($"{_getChekersService}");
            return resHttp.Result;
        }
    }
}