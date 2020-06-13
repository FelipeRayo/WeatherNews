using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherNews.DTO;
using WeatherNews.Services.ExternalServices;

namespace WeatherNews.Services
{
    public class WeatherNewsService
    {
        private readonly ApiExternalService _externalService;

        public WeatherNewsService(ApiExternalService externalService)
        {
            _externalService = externalService;
        }
        public async Task<ApiResponseDTO> GetWeather()
        {
            var apiReponseDTO = new ApiResponseDTO();

            var news = await _externalService.GetNewsAsync();

            apiReponseDTO.News = news;


            return apiReponseDTO;
        }
    }
}
