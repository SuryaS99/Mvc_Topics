using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTask.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {

            ViewData["info1"] = "Data comes from ViewData";
            ViewBag.info2 = "Data comes from ViewBag";
            TempData["info3"] = "Data comes from TempData";
            Session["info4"] = "Data comes from Session";

            string[] Students = { "Ali", "Dipak", "Nisha", "Diu" };
            Session["stuInfo"] = Students;

            return View();
        }

        public ActionResult About()
        {
            if (Session["info4"] != null)
            {
                Session["info4"].ToString();
            }

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}