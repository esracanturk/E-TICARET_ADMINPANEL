﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicaretAPI.Models
{
    public class Users
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool role { get; set; }
        public string email { get; set; }
        public bool emailconfirm { get; set; }
    }
}
