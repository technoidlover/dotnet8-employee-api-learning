﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_api_mongodb.Core.DTOs
{
    public class UsersViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
