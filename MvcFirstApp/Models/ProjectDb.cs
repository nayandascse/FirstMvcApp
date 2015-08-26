using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcFirstApp.Models
{
    public class ProjectDb:DbContext
    {
        public ProjectDb():base("MvrFirstApp")
        {
        
        }

        public DbSet<Department> Departments { set; get; }

        public System.Data.Entity.DbSet<MvcFirstApp.Models.Student> Students { get; set; }

    }
}