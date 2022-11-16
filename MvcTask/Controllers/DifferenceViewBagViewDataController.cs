using MvcTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTask.Controllers
{
    public class DifferenceViewBagViewDataController : Controller
    {
        // GET: DifferenceViewBagViewData
        public ActionResult Index()
        {

            ViewData["Message1"] = "Data Comes From ViewData";
            ViewBag.Message2 = "Data Comes From ViewBag";

            ViewData["CurrentDate1"] = DateTime.Now.ToString();
            ViewBag.CurrentDate2 = DateTime.Now.ToString();


            string[] games = { "Hockey", "Cricket", "Batmintein", "Chess" };

            ViewData["gameArray1"] = games;
            ViewBag.gameArray2 = games;


            Student info = new Student();
            info.StuId = 90;
            info.StuName = "Varsha Davi";
            info.StuAge = 20;

            ViewData["stuinfo1"] = info;
            ViewBag.studinfo2 = info;



            return View();
        }
    }
}