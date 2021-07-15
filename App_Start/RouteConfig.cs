using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Movies",
                url: "Movies",
                defaults: new { controller = "Movies", action = "All", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "One",
                url: "Movies/{id}",
                defaults: new { controller = "Movies", action = "One", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Customers",
                url: "Customers",
                defaults: new { controller = "Customers", action = "All", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CustomersOne",
                url: "Customers/{id}",
                defaults: new { controller = "Customers", action = "One", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
