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

        public async Task<IEnumerable<NewDTO>> GetWeatherAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "http://newsapi.org/v2/everything?q=bitcoin&from=2020-05-12&sortBy=publishedAt&apiKey=2ee3383df4e24e8d89258d546ca6b247");

            var response = await _client.SendAsync(request);

            NewApiResponseDTO newApiResponse = JsonConvert.DeserializeObject<NewApiResponseDTO>(await response.Content.ReadAsStringAsync());

            return newApiResponse.News;
        }
    }
}
