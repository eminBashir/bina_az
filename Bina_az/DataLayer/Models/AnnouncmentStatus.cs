﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class AnnouncmentStatus : BaseEntity
    {
        public int StatusID { get; set; }
        public int AnnoucmentID { get; set; }
        public DateTime ValidityPeriod { get; set; }
    }
}
