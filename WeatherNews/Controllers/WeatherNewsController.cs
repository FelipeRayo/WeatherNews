using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherNews.DTO;
using WeatherNews.Models;
using WeatherNews.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherNews.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherNewsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly WeatherNewsService _service;

        public WeatherNewsController(WeatherNewsService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [Route("history")]
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HistoryDTO>>> GetAll()
        {
            var historyList = await _service.GetHistoryListAsync();

            var historyListDTO = _mapper.Map<IEnumerable<HistoryDTO>>(historyList);

            return historyListDTO.ToList();
        }

        [Route("{city}")]
        [HttpGet]
        public async Task<ApiResponseDTO> Get(string city)
        {   
            return await _service.GetNews(city);
        }
    }
}
