using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP2MVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Class { get; set; }
        public DateTime JoinDate { get; set; }
        public bool HasPaid { get; set; }

    }
}