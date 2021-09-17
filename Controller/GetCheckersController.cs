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
    public class GetCheckersController : ControllerBase
    {
        private readonly ILogger<GetCheckersController> _logger;
        private readonly IGetCheckersService _service;

        public GetCheckersController(ILogger<GetCheckersController> logger, IGetCheckersService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetCheckers()
        {
            var response = new Response<List<Checkers>>();
            try
            {
                response.Result = await _service.GetCheckersList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return Ok(response);
        }
    }
}