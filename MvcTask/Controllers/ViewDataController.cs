using MvcTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTask.Controllers
{
    public class ViewDataController : Controller
    {
        // GET: ViewData
        public ActionResult Index()
        {

            //Single Data
            ViewData["Message"] = "Message from view data!!!";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();

            //Array View
            string[] fruits = { "Apple", "Banana", "Grapes", "Kiwi", "Mango" };
            ViewData["fruitArray"] = fruits;

            //List View
            ViewData["SportsList"] = new List<string>()
            {
                "Cricket","Hockey","VolyBall","FootBall"

            };

            //Object
            Employee ali = new Employee();
            ali.EmpId = 0687;
            ali.EmpName = "Alin Shak";
            ali.EmpDesignation = "Developer";

            ViewData["Employee"] = ali;

            return View();
        }
    }
}