using System.Threading.Tasks;
using GarantsBack.EF;

namespace GarantsBack.Interface
{
    public interface IAuthService
    {
        public Task<string> Login(Login user);
        public Task<User> User(string jwt);
    }
}