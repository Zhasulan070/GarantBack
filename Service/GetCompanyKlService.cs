using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Helpers;
using GarantsBack.Interface;
using Microsoft.Extensions.Configuration;

namespace GarantsBack.Service
{
    public class GetCompanyKlService : IGetCompanyKlService
    {
        private readonly string _getCompanyKlService;

        public GetCompanyKlService(IConfiguration iConfig)
        {
            var servicesUrl = iConfig.GetSection("OFServices").GetSection("Url").Value;
            _getCompanyKlService = servicesUrl + iConfig.GetSection("OFServices").GetSection("GetCompanyKlService").Value;

        }

        public async Task<List<ListKl>> GetKl(string bin)
        {
            var resHttp = await RequestHelper.SendPostRequestAsync<CompanyKl>($"{_getCompanyKlService}{bin}", bin);
            var content = resHttp.result.responseData.ficoLoanResp.loans.loan;
            return content.Where(x => string.IsNullOrEmpty(x.parentContCode))
                          .Select(loan => new ListKl {NameKl = loan.contCode, Amount = loan.credLinAmt})
                          .ToList();
        }
    }
}