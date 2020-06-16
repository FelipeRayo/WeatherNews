using Microsoft.EntityFrameworkCore;
using WeatherNews.Models;

namespace WeatherNews.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> data) : base(data)
        {
        }

        public DbSet<History> History { get; set; }
    }
}
