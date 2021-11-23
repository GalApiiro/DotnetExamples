using System.Web.Mvc;

namespace MvcExamples
{
    public class AnimalController : Controller
    {
        public ActionResult FindMembers(MemberQuery memberQuery)
        {
            var a = EventsController.GetNum();
            return null;
        }
    }
}