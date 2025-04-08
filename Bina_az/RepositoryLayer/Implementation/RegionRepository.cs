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

        public async Task<Region> GetRegionSettlement(int id)
        {
            return await context.Regions
                .Include(p => p.Settlements)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
