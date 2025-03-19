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
    public class AnnouncmentImagesRepository : GenericRepository<AnnouncmentImages>, IAnnouncmentImagesRepository
    {
        public AnnouncmentImagesRepository(AppDbContext context) : base(context)
        {

        }
    }
}
