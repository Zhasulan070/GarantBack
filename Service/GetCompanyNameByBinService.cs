using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Helpers;
using GarantsBack.Interface;
using Microsoft.Extensions.Configuration;

namespace GarantsBack.Service
{
    public class GetCompanyNameByBinService : IGetCompanyNameByBinService
    {
        private readonly string _getCompanyByBinService;

        public GetCompanyNameByBinService(IConfiguration iConfig)
        {
            var servicesUrl = iConfig.GetSection("OFServices").GetSection("Url").Value;
            _getCompanyByBinService = servicesUrl + iConfig.GetSection("OFServices").GetSection("GetCompanyByBinService").Value;
        }

        public async Task<string> GetCompanyName(string bin)
        {
            var resHttp = await RequestHelper.SendPostRequestAsync<CompanyInfo>($"{_getCompanyByBinService}{bin}", bin);
            return resHttp.Result.name_Company;
        }
    }
}