using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WeatherNews.DTO
{
    public class CurrentWeatherDTO
    {
        [JsonProperty("observation_time")]
        public string ObservationTime => DateTime.Now.ToString("hh:mm tt");

        [JsonProperty("temperature")]
        public float Temperature { get; set; }

        [JsonProperty("weather_descriptions")]
        public IEnumerable<string> WeatherDescription { get; set; }

        [JsonProperty("wind_speed")]
        public float WindSpeed { get; set; }

        [JsonProperty("wind_degree")]
        public float WindDegree { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("precip")]
        public int Precipitation { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("cloudcover")]
        public int Cloudcover { get; set; }

        [JsonProperty("feelslike")]
        public float FeelsLike { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }
}
