using System.Web.Mvc;
using System.Web.Routing;

namespace SlugInMVCApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Question_Default",
                url: "question/{id}/{slug}",
                defaults: new { controller = "home", action = "question", id = UrlParameter.Optional, slug = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "home", action = "index", id = UrlParameter.Optional }
            );
        }
    }
}
