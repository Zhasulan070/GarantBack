using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;

namespace GarantsBack.Interface
{
    public interface IGetReferencesService
    {
        public Task<List<Filials>> GetFilials();
        public Task<List<Currencies>> GetCurrencies();
        public Task<List<RequestTypes>> GetRequestTypes();
        public Task<List<Segments>> GetSegments();
    }
}