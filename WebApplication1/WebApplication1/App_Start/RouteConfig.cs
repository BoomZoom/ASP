using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                            name: "Products",
                            url: "Products",
                            defaults: new { controller = "Product", action = "List" });

            //routes.MapRoute(
            //                name: "Product",
            //                url: "Productqwert/{id}",
            //                defaults: new { controler = "Product", action = "ProductId" });

            routes.MapRoute(
                            name: "Product",
                            url: "Product/{id}",
                            defaults: new { controller = "Product", action = "Detail" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
