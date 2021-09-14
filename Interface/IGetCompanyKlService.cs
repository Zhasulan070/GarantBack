using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;

namespace GarantsBack.Interface
{
    public interface IGetCompanyKlService
    {
        Task<List<ListKl>> GetKl(string bin);
    }
}