using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherNews.DTO;
using WeatherNews.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherNews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherNewsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly WeatherNewsService _service;

        public WeatherNewsController(WeatherNewsService service)
        {
            _service = service;
        }

        // GET: api/<WeatherNews>
        [HttpGet]
        public async Task<ApiResponseDTO> Get()
        {   
            return await _service.GetWeather();
        }

       
    }
}
