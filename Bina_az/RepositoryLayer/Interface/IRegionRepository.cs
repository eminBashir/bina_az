using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface IRegionRepository : IGenericRepository<Region>
    {
        Task<List<Region>> GetAllWithCity();
    }
}
