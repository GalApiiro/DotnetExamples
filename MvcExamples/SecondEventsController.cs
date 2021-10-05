using System;
using System.Web.Mvc;
namespace MvcExamples
{
    public class SecondEventsController : Controller
    {
        public ActionResult Until(DateTime entryDate)
        {
            return Content("You requested the events until " + entryDate.ToString());
        }
    }
}