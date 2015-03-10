using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoMVCModel.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Date de naissance")]
        public DateTime BirthDate { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}