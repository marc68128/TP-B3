using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Web;

namespace TP2MVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int Class { get; set; }
        [Display(Name = "Join Date")]
        public DateTime JoinDate { get; set; }
        public bool HasPaid { get; set; }

    }
}