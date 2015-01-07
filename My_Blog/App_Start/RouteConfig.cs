using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace My_Blog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection Routes)
        {
            Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            Routes.MapRoute("Post","post-{title}", new { controller = "Home", action = "Index"});

            Routes.MapRoute("Default","{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional}
                
            );
        }
    }
}