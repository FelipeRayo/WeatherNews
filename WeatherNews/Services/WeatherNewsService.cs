using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherNews.DTO;
using WeatherNews.Models;
using WeatherNews.Services.ExternalServices;
using WeatherNews.Repositories;
using System;
using System.Linq;

namespace WeatherNews.Services
{
    public class WeatherNewsService
    {
        private readonly HistoryRepository _repository;
        private readonly ApiExternalService _externalService;

        public WeatherNewsService(HistoryRepository repository, ApiExternalService externalService)
        {
            _repository = repository;
            _externalService = externalService;
        }

        public async Task<IEnumerable<History>> GetHistoryListAsync()
        {
            return await _repository.GetHistoryListAsync();
        }

        public async Task<History> GetHistoryAsync(int id)
        {
            return await _repository.GetHistoryAsync(id);
        }

        public async Task<ApiResponseDTO> GetNews(string city)
        {
            var apiReponseDTO = new ApiResponseDTO();

            var news = await _externalService.GetNewsAsync();
            apiReponseDTO.News = news;

            var weatherResponse = await _externalService.GetWeatherAsync(city);
            apiReponseDTO.CurrentWeather = new CurrentWeatherDTO
            {
                
                Temperature = weatherResponse.Main.Temperature - (float)273.15,
                WeatherDescription = weatherResponse.Weather.Select(t => t.Description),
                WindSpeed = weatherResponse.Wind.Speed,
                WindDegree = weatherResponse.Wind.Degree,
                Pressure = weatherResponse.Main.Pressure,
                Humidity = weatherResponse.Main.Humidity,
                Cloudcover = weatherResponse.Clouds.Cloud,
                FeelsLike = weatherResponse.Main.FeelsLike,
                Visibility = weatherResponse.Visibility,
                City = weatherResponse.City
                
            };

            var history = new History
            {
                City = weatherResponse.City,
                Info = $"Consulted on {DateTime.Now}"
            };

            await _repository.AddHistoryAsync(history);

            return apiReponseDTO;
        }
    }
}
