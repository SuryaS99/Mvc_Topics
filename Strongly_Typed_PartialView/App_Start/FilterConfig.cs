using System.Web;
using System.Web.Mvc;

namespace Strongly_Typed_PartialView
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
