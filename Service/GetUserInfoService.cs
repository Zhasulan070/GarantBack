using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Helpers;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.Extensions.Configuration;

namespace GarantsBack.Service
{
    public class GetUserInfoService : IGetUserInfoService
    {
        private readonly string _getUserInfoService;
        
        public GetUserInfoService(IConfiguration iConfig)
        {
            var servicesUrl = iConfig.GetSection("OFServices").GetSection("Url").Value;
            _getUserInfoService = servicesUrl + iConfig.GetSection("OFServices").GetSection("GetValidatedUserService").Value;

        }
        public async Task<UserInfo> GetUser(LoginModel loginModel)
        {
            var resHttp = await RequestHelper.SendPostRequestAsync<UserInfo>($"{_getUserInfoService}eMailOrUsername{loginModel.EMailOrUsername}&password={loginModel.Password}", loginModel);
            return resHttp;
        }
    }
}