using System.Web.Mvc;
using System.Web.Routing;

namespace MvcExamples
{
    public class Global : HttpApplication
    {
        private static void RegisterRoutes1(RouteCollection routes)
        {
            routes.MapRoute(
                "EventsSince1",
                "EventsSince1/{action}/{entryDate}",
            new { controller = "Events", action = "Since" }
                );
            routes.MapRoute(
                "EventsSince2",
                "EventsSince2/{action}/{entryDate}",
            new { controller = "Events" }
                );
            routes.MapRoute(
                "Until",
                "{controller}/Until/{entryDate}",
            new { action = "Until" }
                );
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
            new { controller = "Home", action = "Index", id = "" }
                );
        }
        
        private static void RegisterAnimalRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                "Animal",
                "animal/{action}",
                new { controller = "Animal", }
            );
            routes.MapRoute(
                "AnimalByMember",
                "animal/{action}/member/{member}",
                new { controller = "Animal", }
            );
        }
                
        protected void Application_Start()
        {
            RegisterRoutes1(RouteTable.Routes);
            RegisterAnimalRoutes(RouteTable.Routes);
        }
    }  
}