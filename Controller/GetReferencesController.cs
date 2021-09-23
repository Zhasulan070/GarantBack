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
    public class GetReferencesController : ControllerBase
    {
        private readonly IGetReferencesService _service;
        private readonly ILogger<GetReferencesController> _logger;

        public GetReferencesController(IGetReferencesService service, ILogger<GetReferencesController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("GetFilials")]
        public async Task<IActionResult> GetFilials()
        {
            var response = new Response<List<Filials>>();
            try
            {
                response.Result = await _service.GetFilials();
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in GetFilials service";
                _logger.LogError(e, response.ErrorMessage);
            }
            
            return Ok(response);
        }
        
        [HttpGet("GetCurrencies")]
        public async Task<IActionResult> GetCurrencies()
        {
            var response = new Response<List<Currencies>>();
            try
            {
                response.Result = await _service.GetCurrencies();
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in GetCurrencies service";
                _logger.LogError(e, response.ErrorMessage);
            }
            
            return Ok(response);
        }
        
        [HttpGet("GetRequestTypes")]
        public async Task<IActionResult> GetRequestTypes()
        {
            var response = new Response<List<RequestTypes>>();
            try
            {
                response.Result = await _service.GetRequestTypes();
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in GetRequestTypes service";
                _logger.LogError(e, response.ErrorMessage);
            }
            
            return Ok(response);
        }
        
        [HttpGet("GetSegments")]
        public async Task<IActionResult> GetSegments()
        {
            var response = new Response<List<Segments>>();
            try
            {
                response.Result = await _service.GetSegments();
                response.StatusCode = 0;
            }
            catch (Exception e)
            {
                response.StatusCode = -1;
                response.ErrorMessage = "Some error in GetSegments service";
                _logger.LogError(e, response.ErrorMessage);
            }
            
            return Ok(response);
        }
    }
}