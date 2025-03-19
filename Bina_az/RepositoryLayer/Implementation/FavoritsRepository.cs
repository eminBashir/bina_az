using DataLayer.Data;
using DataLayer.Models;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Implementation
{
    public class FavoritsRepository : GenericRepository<Favorits>, IFavoritsRepository
    {
        public FavoritsRepository(AppDbContext context) : base(context)
        {

        }
    }
}
