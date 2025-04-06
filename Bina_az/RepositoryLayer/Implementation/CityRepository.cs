using DataLayer.Data;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Implementation
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        private readonly AppDbContext context;

        public CityRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }
        public async Task<City> GetCityWithRegions(int id)
        {
            return await context.Cities
                        .Include(c => c.Regions)
                        .FirstOrDefaultAsync(c => c.Id == id);
        }


    }
}
