using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP7SchoolManagement.Models;

namespace TP7SchoolManagement.ViewModels
{
    public class DashboardViewodel
    {
        public DashboardViewodel()
        {
            SelectedSchoolName = "All";
        }

        public IEnumerable<School> Schools { get; set; }
        public IEnumerable<Student> Students { get; set; }

        public string SelectedSchoolName { get; set; }
    }
}