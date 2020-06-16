using Newtonsoft.Json;

namespace WeatherNews.DTO
{
    public class HistoryDTO
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

    }
}
