using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GarantsBack.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaveFileController : ControllerBase
    {
        private readonly ILogger<SaveFileController> _logger;
        private readonly IWebHostEnvironment _appEnvironment;
        private readonly ISaveFileService _service;

        public SaveFileController(ILogger<SaveFileController> logger, IWebHostEnvironment appEnvironment, ISaveFileService service)
        {
            _logger = logger;
            _appEnvironment = appEnvironment;
            _service = service;
        }
        
        [HttpPost]
        public async Task<IActionResult> AddFile(IFormCollection files)
        {

            var response = new Response<List<FileModel>>();
            try
            {
                response.Result = await _service.SaveFile(files);
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in SaveFile service";
                _logger.LogError(e, response.ErrorMessage);
            }
            
            return Ok(response);
        }
        
    }
}