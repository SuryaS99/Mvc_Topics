using System.Web.Mvc;

namespace RouteAttributeCustom.Controllers
{
    public class HomeController : Controller
    {
        // GET: RouteAttribute
        public ActionResult Index()
        {
            return View();
        }

        //[Route("routeattri/released/{year}/{month}")]
        public ActionResult ByReleaseYear()
        {
            return View();
        }
    }
}