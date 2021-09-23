using System;
using System.Threading.Tasks;
using GarantsBack.EF;
using GarantsBack.Interface;
using GarantsBack.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace GarantsBack.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger, IAuthService service)
        {
            _logger = logger;
            _service = service;
        }
        
        [HttpPost("loginByUserId")]
        public async Task<IActionResult> LoginBtUserId([FromBody] Login user)
        {
            var response = new Response<User>();

            try
            {
                var res = await _service.LoginByUserId(user);
                Response.Cookies.Append("userId", res.Id.ToString(), new CookieOptions
                {
                    HttpOnly = true
                });

                response.Result = res;
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in LoginByUserId service";
                _logger.LogError(e, response.ErrorMessage);
            }

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] Login user)
        {
            var response = new Response<string>();

            try
            {
                var res = await _service.Login(user);
                Response.Cookies.Append("jwt", res, new CookieOptions
                {
                    HttpOnly = true
                });

                response.Result = "JWT token added to Cookies";
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in LoginUser service";
                _logger.LogError(e, response.ErrorMessage);
            }

            return Ok(response);
        }

        [HttpGet("user")]
        public async Task<IActionResult> User()
        {
            var response = new Response<User>();
            var jwt = Request.Cookies["userId"];

            try
            {
                if (jwt == null)
                {
                    throw new SecurityTokenUnableToValidateException();
                }
                response.Result = await _service.User(jwt);
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                if (e is SecurityTokenUnableToValidateException)
                {
                    return Unauthorized();
                }
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in User service";
                _logger.LogError(e, response.ErrorMessage);
            }

            return Ok(response);
        }
        
        [HttpPost("logout")]
        public async Task<IActionResult> UserLogout()
        {
            var response = new Response<string>();

            try
            {
                Response.Cookies.Delete("userId");
                response.Result = "was completed successfully";
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in Logout service";
                _logger.LogError(e, response.ErrorMessage);
            }

            return Ok(response);
        }
    }
}