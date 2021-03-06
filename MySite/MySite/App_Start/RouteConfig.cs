﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MySite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "AdminAuth",
                url: "test",
                defaults: new { controller = "Admin", action = "Login" }
            );

            //routes.MapRoute(
            //    name: "UserAuth",
            //    url: "{controller}",
            //    defaults: new { controller = "Account", action = "Login" }
            //);
            
        }
    }
}
