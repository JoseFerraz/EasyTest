using System.Web.Mvc;
using System.Web.Routing;

namespace EasyTest.UI.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Work with us - Developer",
                url: "work-with-us/developer",
                defaults: new { controller = "TalentBank", action = "DevelopersForm" }
            );

            routes.MapRoute(
                name: "Talent Bank - Developers",
                url: "talent-bank/developers",
                defaults: new { controller = "TalentBank", action = "Developers" }
            );

            routes.MapRoute(
                name: "Talent Bank - Developers - Developer Details",
                url: "talent-bank/developers/details/{id}",
                defaults: new { controller = "TalentBank", action = "DeveloperDetails" }
            );

            routes.MapRoute(
                name: "Talent Bank - Developers - Developer Edit",
                url: "talent-bank/developers/edit/{id}",
                defaults: new { controller = "TalentBank", action = "DeveloperEdit" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
