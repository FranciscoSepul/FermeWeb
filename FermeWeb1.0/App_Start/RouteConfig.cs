using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FermeWeb1._0
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
<<<<<<< HEAD
                defaults: new { controller = "Cliente", action = "logIn", id = UrlParameter.Optional }
=======
                defaults: new { controller = "Empleado", action = "empleados", id = UrlParameter.Optional }
>>>>>>> afe3300185f51ebf482daf8f3a6b47e2e5ee56ae
            );
        }
    }
}
