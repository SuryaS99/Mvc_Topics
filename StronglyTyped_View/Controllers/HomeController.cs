using StronglyTyped_View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTyped_View.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employee emp1 = new Employee();
            emp1.Id = 93;
            emp1.Name = "Anika";
            emp1.Age = 20;

            Employee emp2 = new Employee();
            emp2.Id = 97;
            emp2.Name = "Nikita";
            emp2.Age = 25;

            Employee emp3 = new Employee();
            emp3.Id = 94;
            emp3.Name = "Ankita";
            emp3.Age = 23;

            ViewData["info"] = emp1;

            ViewBag.info1 = emp1;

            //how to pass list of object with strongly typed view

            List<Employee> EmployeeLists = new List<Employee>();
            EmployeeLists.Add(emp1);
            EmployeeLists.Add(emp2);
            EmployeeLists.Add(emp3);


            //return View(emp1); //single object pass 
            return View(EmployeeLists); //multiple object pass 
        }
    }
}