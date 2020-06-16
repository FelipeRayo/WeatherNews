using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherNews.DTO
{
    public class CloudDTO
    {
        [JsonProperty("all")]
        public int Cloud { get; set; }
    }
}
