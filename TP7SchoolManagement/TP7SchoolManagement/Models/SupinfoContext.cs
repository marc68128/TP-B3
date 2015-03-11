using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP7SchoolManagement.Models
{
    public class SupinfoContext : DbContext
    {
        public SupinfoContext() : base("SupinfoContext")
        { }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}