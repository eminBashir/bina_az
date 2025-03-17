﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Register
    {
        public string UserName { get; set; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
