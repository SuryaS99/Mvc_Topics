using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTask.Controllers
{
    public class ActionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public string Show()
        {
            return "This is a second controller of action";
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public int StudentId(int id)
        {
            return id;
        }

    }
}