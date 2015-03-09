using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP1WebForm.Model;

namespace TP1WebForm
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                var student = new Model.Student
                {
                    FirstName = FirstName.Value,
                    LastName = LastName.Value,
                    IdBooster = Int32.Parse(IdBooster.Value)
                };

                using (var context = new SchoolDbContext())
                {
                    context.Students.Add(student);
                    context.SaveChanges(); 
                }

            }
        }
    }
}