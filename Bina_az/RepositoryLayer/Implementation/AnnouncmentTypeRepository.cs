﻿using DataLayer.Data;
using DataLayer.Models;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Implementation
{
    public class AnnouncmentTypeRepository : GenericRepository<AnnouncmentType>, IAnnouncmentTypeRepository
    {
        public AnnouncmentTypeRepository(AppDbContext context) : base(context)
        {

        }
    }
}
