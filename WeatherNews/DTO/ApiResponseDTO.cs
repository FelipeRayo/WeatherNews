using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherNews.DTO
{
    public class ApiResponseDTO
    {
        [JsonProperty("news")]
        public IEnumerable<NewDTO> News { get; set; }

        [JsonProperty("current_weather")]
        public CurrentWeatherDTO CurrentWeather { get; set; }
    }
}
