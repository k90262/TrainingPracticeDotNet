using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HealthController : Controller
    {
        // GET: Health
        public ActionResult BMI()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BMI(double Height, double Weight)
        {
            double h = Height / 100;
            double bmi = Weight / h / h;

            ViewBag.Height = Height;
            ViewBag.Weight = Weight;
            ViewBag.BMI = bmi;
            return View();
        }
    }
}