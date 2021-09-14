using System.Threading.Tasks;

namespace GarantsBack.Interface
{
    public interface IGetCompanyNameByBinService
    {
        Task<string> GetCompanyName(string bin);
    }
}