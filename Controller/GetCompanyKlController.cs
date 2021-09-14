using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace GarantsBack.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCompanyKlController : ControllerBase
    {
        private readonly IGetCompanyKlService _service;
        private readonly ILogger<GetCompanyKlController> _logger;

        public GetCompanyKlController(IGetCompanyKlService service, ILogger<GetCompanyKlController> logger)
        {
            _service = service;
            _logger = logger;
        }
        
        [HttpPost]
        public async Task<IActionResult> GetKl([FromQuery(Name = "bin")] string bin)
        {
            var response = new Response<List<ListKl>>();
            try
            {
                response.Result = await _service.GetKl(bin);
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in GetKL service";
                _logger.LogError(e, response.ErrorMessage);
            }

            return Ok(response);
        }
    }
}