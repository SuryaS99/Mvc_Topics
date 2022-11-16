using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            ViewBag.countries = new List<string>()
            {
                "Uk","India","Austrlia"
            };

            ViewData["Info"] = new List<string>() {
             "Uk","India","Austrlia","japan"
            };
            return View();
        }

        //public List<string> Index()
        //{
        //    return new List<string>() 
        //    { 
        //        "Uk","India","Austrlia"
        //    };
        //}
    }
}