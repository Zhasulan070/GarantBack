using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;
using Microsoft.AspNetCore.Http;

namespace GarantsBack.Interface
{
    public interface ISaveFileService
    {
        public Task<List<FileModel>> SaveFile(IFormCollection files);
    }
}