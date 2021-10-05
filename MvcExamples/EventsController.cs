using System;
using System.Web.Mvc;
namespace MvcExamples
{
    public class EventsController : Controller
    {
        public ActionResult Since(DateTime entryDate)
        {
            return Content("You requested the events since " + entryDate.ToString());
        }
                    
        public string NoAction(){
            return "This is not an action method";
        }
    }
}