using DataLayer.Data;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Implementation
{
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        private readonly AppDbContext context;

        public RegionRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<Region>> GetAllWithCity()
        {
            return await context.Regions
                          .Include(r => r.City)
                          .ToListAsync();
        }
    }
}
