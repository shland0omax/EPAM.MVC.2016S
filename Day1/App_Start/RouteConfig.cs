using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Day1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //attributes binded
            //routes.MapMvcAttributeRoutes();

            //static, optional, custom
            routes.MapRoute(
                "custom",
                "JSON/{controller}/{action}/{id}/{optionalId}",
                new { controller = "Home", action = "Index", optionalId = UrlParameter.Optional, id = 22 },
                new[] { "AsideControllers" }
            );

            //constraints
            routes.MapRoute(
                name:"constrained",
                url: "{controller}/{action}/{id}",
                defaults: new {id = 13},
                constraints: new { controller = "^T.*", httpMethod = new HttpMethodConstraint("GET") }
            );

            //namespace priority
            routes.MapRoute(
                name: "Namespace",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" },
                namespaces: new[] { "Day1.Controllers" }
            );

            //default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
