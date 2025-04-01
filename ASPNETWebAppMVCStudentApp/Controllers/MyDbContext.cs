using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Configuration;
using ASPNETWebAppMVCStudentApp.Models;

namespace ASPNETWebAppMVCStudentApp.Controllers
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("SchoolDBqEntities") { }

        public DbSet<tblUser> tblUser { get; set; }
    }
}

namespace ASPNETWebAppMVCStudentApp.Models
{
    public class tblUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        // Add other properties as needed
    }
}
