using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTask.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index()
        {

            ViewData["var1"] = "message from view data";

            ViewBag.var2 = "message from view bag";

            //tempdata["var3"] = "message from temp data";
            TempData["var3"] = "hello";


            int Name = 1;
            TempData["int"] = Name;



            string[] games = { "cricket", "hockey", "Baseball" };

            TempData["gamesArray"] = games;




            //return View();

            return RedirectToAction("About"); // to redirect the action view
        }

        public ActionResult About()
        {
            //int id = Convert.ToInt32(TempData["int"]);

            if (TempData["Var3"] != null)
            {
                TempData["Var3"].ToString();
            }

            TempData.Keep(); // to save the data in about action
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}