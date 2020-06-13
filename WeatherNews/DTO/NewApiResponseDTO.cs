using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherNews.DTO
{
    public class NewApiResponseDTO
    {
        [JsonProperty("articles")]
        public IEnumerable<NewDTO> News { get; set; }

    }
}
