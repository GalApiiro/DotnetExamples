using System;
using System.Web.Mvc;

namespace MvcExamples
{
    public class ArchiveController : Controller
    {
        public string Entry(DateTime entryDate)
        {
            return "You requested the entry from " + entryDate.ToString();
        }
    }
}