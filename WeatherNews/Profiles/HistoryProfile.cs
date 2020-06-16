using AutoMapper;
using WeatherNews.DTO;
using WeatherNews.Models;

namespace WeatherNews.Profiles
{
    public class HistoryProfile : Profile
    {
        public HistoryProfile()
        {
            CreateMap<HistoryDTO, History>();
            CreateMap<History, HistoryDTO>();
        }
    }
}
