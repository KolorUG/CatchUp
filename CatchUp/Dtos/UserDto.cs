﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatchUp.Helpers;

namespace CatchUp.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType{ get; set; }
    }
}
