using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherNews.DTO
{
    public class MainDTO
    {
        [JsonProperty("temp")]
        public float Temperature { get; set; }

        

    }
}
