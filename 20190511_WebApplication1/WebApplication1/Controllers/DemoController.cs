using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    [RoutePrefix("super")]
    public class DemoController : Controller
    {
        // GET: Demo
        //[ActionName("GoGo")]
        [Route("Get/Bad{name}/Out/{age}YearsOld")]
        public ActionResult Index(string name, int? age)
        {
            return View("Hello"); //有八種可以試
        }

        //[Route("{year}/{month:min(1):max(12)}/{day}")]
        //public ActionResult Go(int year, int month, int day)
        [Route("{*date:datetime}")]
        public ActionResult Go(DateTime date)
        {
            return View("Index");
        }
    }
}