using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Detail()
        {
            Employee info = new Employee()
            {
                EmployeeId = 002,
                Name = "Gunjan",
                gender = "Female",
                city = "Mumbai"

            };
            return View();
        }
    }
}