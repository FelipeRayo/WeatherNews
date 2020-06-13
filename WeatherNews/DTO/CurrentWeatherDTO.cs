using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherNews.DTO
{
    public class CurrentWeatherDTO
    {
        [JsonProperty("observation_time")]
        public string ObservationTime => DateTime.Now.ToString("hh:mm tt");

        [JsonProperty("temperature")]
        public float Temperature { get; set; }

        [JsonProperty("weather_descriptions")]
        public  IEnumerable<string> WeatherDescription { get; set; }

        [JsonProperty("wind_speed")]
        public float WindSpeed { get; set; }



 //"wind_degree": 349,
 //"wind_dir": "N",
 //"pressure": 1010,
 //"precip": 0,
 //"humidity": 90,
 //"cloudcover": 0,
 //"feelslike": 13,
 //"uv_index": 4,
 //"visibility": 16

        


    }
}
