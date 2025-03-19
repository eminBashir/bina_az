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
    public class AnnouncmentStatusRepository : GenericRepository<AnnouncmentStatus>, IAnnouncmentStatusRepository
    {
        public AnnouncmentStatusRepository(AppDbContext context) : base(context)
        {

        }
    }
}
