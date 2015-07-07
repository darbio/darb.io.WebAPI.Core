﻿using System.Web;
using System.Web.Mvc;

namespace NSWRFS.Base.Api
{
    using NSWRFS.Base.Api.Filters;

    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
