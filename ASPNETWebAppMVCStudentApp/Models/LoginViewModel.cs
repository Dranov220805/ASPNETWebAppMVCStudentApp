﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETWebAppMVCStudentApp.Models
{
    public class LoginViewModel
    {
        public int UserId {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}