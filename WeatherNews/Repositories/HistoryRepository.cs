using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherNews.Models;

namespace WeatherNews.Repositories
{
    public class HistoryRepository
    {
        private readonly DataContext _context;
        public HistoryRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<History>> GetHistoryListAsync()
        {
            return await _context.History.ToListAsync();
        }

        public async Task AddHistoryAsync(History history)
        {
            _context.History.Add(history);
            await _context.SaveChangesAsync();
        }

        public async Task<History> GetHistoryAsync(int id)
        {
            return await _context.History.FindAsync(id);
        }
    }
}
