﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Settlement : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public int RegionID { get; set; }
        public Region Region { get; set; }
    }
}
