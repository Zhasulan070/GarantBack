using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Helpers;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.Extensions.Configuration;

namespace GarantsBack.Service
{
    public class GetCompanyNameByBinService : IGetCompanyNameByBinService
    {
        private readonly string _getCompanyByBinService;

        public GetCompanyNameByBinService(IConfiguration iConfig)
        {
            var servicesUrl = iConfig.GetSection("LocalServices").GetSection("Url").Value;
            _getCompanyByBinService = servicesUrl + iConfig.GetSection("LocalServices").GetSection("GetCompanyByBinService").Value;
        }

        public async Task<string> GetCompanyName(string bin)
        {
            var resHttp = await RequestHelper.SendGetRequestAsync<Response<LoanRequest>>($"{_getCompanyByBinService}{bin}");
            return resHttp.Result.CompanyName;
        }
    }
}