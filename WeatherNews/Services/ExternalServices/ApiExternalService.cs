using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherNews.DTO;

namespace WeatherNews.Services.ExternalServices
{
    public class ApiExternalService
    {
        private readonly HttpClient _client;

        public ApiExternalService()
        {
            _client = new HttpClient();
        }

        public async Task<IEnumerable<NewDTO>> GetNewsAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://newsapi.org/v2/everything?q=bitcoin&apiKey=2ee3383df4e24e8d89258d546ca6b247");

            var response = await _client.SendAsync(request);

            NewApiResponseDTO newApiResponse = JsonConvert.DeserializeObject<NewApiResponseDTO>(await response.Content.ReadAsStringAsync());

            return newApiResponse.News;
        }

        public async Task<WeatherResponseDTO> GetWeatherAsync(string city)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=ea7e571835ddb82520814251f831c789");

            var response = await _client.SendAsync(request);

            WeatherResponseDTO weatherResponse = JsonConvert.DeserializeObject<WeatherResponseDTO>(await response.Content.ReadAsStringAsync());

            return weatherResponse;
        }
    }
}
