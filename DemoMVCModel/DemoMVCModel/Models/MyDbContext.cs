using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoMVCModel.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyContext")
        {
            
        }
        public DbSet<Person> Persons { get; set; }
    }
}