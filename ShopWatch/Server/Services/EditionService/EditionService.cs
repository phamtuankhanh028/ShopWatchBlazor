using Microsoft.EntityFrameworkCore;
using ShopWatch.Server.Data;
using ShopWatch.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopWatch.Server.Services.EditionService
{
    public class EditionService : IEditionService
    {
        private readonly DataContext _context;

        public EditionService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Edition>> GetEditions()
        {
            return await _context.Editions.ToListAsync();
        }
    }
}
