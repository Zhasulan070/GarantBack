using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Helpers;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.Extensions.Configuration;

namespace GarantsBack.Service
{
    public class AuthService : IAuthService
    {
        private readonly string _getAuthService;
        
        public AuthService(IConfiguration iConfig)
        {
            var servicesUrl = iConfig.GetSection("LocalServices").GetSection("Url").Value;
            _getAuthService = servicesUrl + iConfig.GetSection("LocalServices").GetSection("AuthService").Value;
        }

        public async Task<string> Login(Login user)
        {
            var resHttp = await RequestHelper.SendPostRequestAsync<Response<string>>($"{_getAuthService}login?username={user.Username}&password={user.Password}", user);
            return resHttp.Result;
        }

        public async Task<User> User(string jwt)
        {
            var resHttp = await RequestHelper.SendGetRequestAsync<Response<User>>($"{_getAuthService}user?jwt={jwt}");
            return resHttp.Result;
        }
    }
}