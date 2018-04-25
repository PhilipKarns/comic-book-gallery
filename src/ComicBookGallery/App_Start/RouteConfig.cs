using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ComicBookGallery
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //this line of code tells router to ignore all files with .axd extension. These files need to be handled by asp.net and never routed to controller
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //this is the definition for our default route, which has the route name, the URL pattern that the route should match, and the default values for the route's URL Parameters
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ComicBooks", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
