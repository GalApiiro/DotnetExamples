using System.Web.Mvc;
using System.Web.Routing;

namespace MvcExamples
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
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
                
        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }
    }  
}