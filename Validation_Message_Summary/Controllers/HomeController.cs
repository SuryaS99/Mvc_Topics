using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Validation_Message_Summary.Controllers
{
    public class HomeController : Controller
    {
        //[RegularExpression(@"\A(?:[a-z0-9!#$%&'+/=?^_{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-][a-z0-9])?)\Z",
        //ErrorMessage = "Please enter correct email address")]


        //public string email { get; set; }

        string emailPattern = "^[a-za-z0-9_\\.-]+@([a-za-z0-9-]+\\.)+[a-za-z]{2,6}$";
        //string PassPattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[$@$!%*?&])[A-Za-z\\d$@$!%*?&]{12,}";

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //request post on button click
        [HttpPost]
        public ActionResult Index(string fullName, string Age, string Email)
        {
            //fullname validation
            if (fullName.Equals("") == true)
            {
                ModelState.AddModelError("fullName", "Full name is required!!");
                ViewData["fullNameError"] = "*";
            }
            //age validation
            if (Age.Equals("") == true)
            {
                ModelState.AddModelError("Age", "Age is required!!");
                ViewData["AgeError"] = "*";
            }
            //email validation
            if (Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is required!!");
                ViewData["EmailError"] = "*";
            }
            else
            {
                if (Regex.IsMatch(Email, emailPattern) == false)
                {

                    ModelState.AddModelError("Email", "Invalid Email");
                    ViewData["EmailError"] = "*";
                }
            }

            if (ModelState.IsValid == true)
            {
                //javascript alert method is used
                ViewData["SucessMessage"] = "<script>alert('Data has been submited')</script>";

                ModelState.Clear();
            }



            return View();
        }
    }
}