﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Favorits : BaseEntity
    {
        public int AnnouncmentID { get; set; }
        public int UserId { get; set; }
       // public User User { get; set; }
        public Announcment Announcment { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
