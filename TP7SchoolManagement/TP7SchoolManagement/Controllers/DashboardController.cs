using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP7SchoolManagement.Models;
using TP7SchoolManagement.ViewModels;

namespace TP7SchoolManagement.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index(string schoolName)
        {
            using (var context = new SupinfoContext())
            {
                var Students = context.Students.ToList();
                var allSchools = context.Schools.ToList();

                if (schoolName != null && schoolName != "All")
                    Students = Students.Where(s => s.School.Name == schoolName).ToList();

                return View(new DashboardViewodel
                {
                    Students = Students,
                    Schools = allSchools,
                    SelectedSchoolName = schoolName ?? "All"
                });
            }
            
        }
    }
}