﻿using System.Web;
using System.Web.Mvc;

namespace Attribute_Convention_Route
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
