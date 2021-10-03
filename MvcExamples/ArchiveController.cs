using System;
using System.Web.Mvc;
namespace MvcExamples
{
    public class ArchiveController : Controller
    {
        public ActionResult Entry(DateTime entryDate)
        {
            return Content("You requested the entry from " + entryDate.ToString());
        }
    }
}