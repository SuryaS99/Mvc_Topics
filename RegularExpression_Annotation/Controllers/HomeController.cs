using RegularExpression_Annotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegularExpression_Annotation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee e)
        {
            if (ModelState.IsValid == true)
            {
                ViewData["Success"] = "<script>alert('Data has been Submitted!!')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}