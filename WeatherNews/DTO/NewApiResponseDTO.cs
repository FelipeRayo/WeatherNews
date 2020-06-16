using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherNews.DTO
{
    public class NewApiResponseDTO
    {
        [JsonProperty("articles")]
        public IEnumerable<NewDTO> News { get; set; }

    }
}
