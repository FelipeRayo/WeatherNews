using Newtonsoft.Json;

namespace WeatherNews.DTO
{
    public class WeatherDTO
    {
        [JsonProperty("description")]
        public string Description { get; set; }

    }
}
