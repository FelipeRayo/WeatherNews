using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherNews.DTO
{
    public class WeatherResponseDTO
    {

        [JsonProperty("weather")]
        public IEnumerable<WeatherDTO> Weather { get; set; }

        [JsonProperty("main")]
        public MainDTO Main { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("wind")]
        public WindDTO Wind { get; set; }

        [JsonProperty("clouds")]
        public CloudDTO Clouds { get; set; }

        [JsonProperty("name")]
        public string City { get; set; }

    }
}
