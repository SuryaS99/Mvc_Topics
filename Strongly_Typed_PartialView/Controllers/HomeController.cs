using Strongly_Typed_PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Strongly_Typed_PartialView.Controllers
{
    public class HomeController : Controller
    {

        List<Product> ProductsList = new List<Product>()
        {
            new Product{id=1,name="Reebok Shoes", price=1000.00, picture="~/images/REEBOK.jpg"},
            new Product{id=2,name="REYBEN Shoes", price=15000.00, picture="~/images/REYBEN.jpg"},
            new Product{id=3,name="ROLEX Shoes", price=2000.00, picture="~/images/ROLEX.jpeg"}
        };

        // GET: Home
        public ActionResult Index()
        {
            return View(ProductsList); //object pass
        }
    }
}