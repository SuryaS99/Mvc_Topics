using MvcTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTask.Controllers
{
    public class ViewBagController : Controller
    {
        // GET: ViewBag
        public ActionResult Index()
        {
            ViewBag.Message = "Message send from View Bag!!";

            ViewBag.Date = DateTime.Now.ToLongDateString();

            //Array
            string[] fruits = { "Apple", "Banana", "Grapes" };
            ViewBag.FruitsArray = fruits;

            //List

            ViewBag.sportsList = new List<string>()
            {
                "Cricket","Football","Hockey","Baseball"
            };

            //Object

            Employeee Manas = new Employeee();
            Manas.EmpID = 0585;
            Manas.EmpName = "Manas Khureshi";
            Manas.EmpDesig = "Accountent";

            ViewBag.Info = Manas;


            ViewBag.CommonMessage = " This message is accessible by both the view bag and view data";

            return View();
        }
    }
}