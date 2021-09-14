using System;
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
    
    public class GetUserInfoController : ControllerBase
    {
        private readonly IGetUserInfoService _service;
        private readonly ILogger<GetUserInfoController> _logger;

        public GetUserInfoController(IGetUserInfoService service, ILogger<GetUserInfoController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> GetUser([FromBody] LoginModel loginModel)
        {
            var response = new Response<UserInfo>();
            
            try
            {
                response.Result = _service.GetUser(loginModel).Result;
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in GetUser service";
                _logger.LogError(e, response.ErrorMessage);
            }

            return Ok(response);
        }
    }
}