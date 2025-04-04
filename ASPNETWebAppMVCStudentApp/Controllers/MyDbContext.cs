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
        public MyDbContext() : base("SchoolDBConnectionString") { }

        public DbSet<tblUsers> tblUsers { get; set; }
    }
}
