﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRMProject.Models
{
    public class AppointmentUserModel
    {
        public User user { get; set; }

        public List<User> userList { get; set; }
    }
}
