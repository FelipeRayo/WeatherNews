using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherNews.DTO
{
    public class WeatherApiResponseDTO
    {
        [JsonProperty("weather")]
        public WeatherDTO Weather { get; set; }


    }
}
