using System;
using System.Threading.Tasks;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GarantsBack.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class GetCompanyNameByBinController : ControllerBase
    {
        private readonly IGetCompanyNameByBinService _service;
        private readonly ILogger<GetCompanyNameByBinController> _logger;

        public GetCompanyNameByBinController(IGetCompanyNameByBinService service, ILogger<GetCompanyNameByBinController> logger)
        {
            _service = service;
            _logger = logger;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetCompany([FromQuery(Name = "bin")] string bin)
        {
            var response = new Response<string>();
            try
            {
                response.Result = await _service.GetCompanyName(bin);
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in GetCompanyName service";
                _logger.LogError(e, response.ErrorMessage);
            }

            return Ok(response);
        }
    }
}