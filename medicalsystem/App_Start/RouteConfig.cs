using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace medicalsystem
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*robotstxt}", new { robotstxt = @"(.*/)?robots.txt(/.*)?" });
            //routes.IgnoreRoute("{*sitemapxml}", new { robotstxt = @"(.*/)?sitemap.xml(/.*)?" });
            routes.IgnoreRoute("favicon.ico");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "UserManagement", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
              name: "HomeStreamerSection",
              url: "{lang}/GetStreamerSection",
              defaults: new { controller = "Home", action = "Index", lang = "ar" }
          );
        }
    }
}
