using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace TP7SchoolManagement.Models
{
    public class Student
    {
        //public string Id { get { return Key1 + Key2; } }
        //public string Key1 { get; set; }
        //public string Key2 { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate  { get; set; }
        public bool HasPaid { get; set; }
        public int Class { get; set; }

        [Display(Name = "School")]
        public int SchoolId { get; set; }

        [JsonIgnore]
        [Display(Name = "School")]
        public virtual School School { get; set; }
    }
}