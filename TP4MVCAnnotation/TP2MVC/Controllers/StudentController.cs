using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP2MVC.Models;
using TP2MVC.ViewModels;

namespace TP2MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Detail()
        { 
            var student = new Student
            {
                Name = "Toto", 
                Class = 3, 
                Email = "toto@toto.fr", 
                JoinDate = DateTime.Now, 
                HasPaid = true
            };

           

            return View(new DetailViewModel
            {
                Student = student,
                School = "Supinfo"
            });
        }
    }
}