using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TP2MVC.Models;
using TP2MVC.ViewModels;

namespace TP2MVC.Controllers
{
    public class Student2Controller : Controller
    {
        // GET: Student2
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateViewModel vm)
        {
            if (ModelState.IsValid)
            {
                using (var context = new SchoolContext())
                {
                    context.Students.Add(vm.Student);
                    context.SaveChanges();
                }
            }
            return null;
        }
    }
}