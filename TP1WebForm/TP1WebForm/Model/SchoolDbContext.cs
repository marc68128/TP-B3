using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TP1WebForm.Model
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("SchoolContext")
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}