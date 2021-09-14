using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Model;

namespace GarantsBack.Interface
{
    public interface IGetUserInfoService
    {
        public Task<UserInfo> GetUser(LoginModel loginModel);
    }
}