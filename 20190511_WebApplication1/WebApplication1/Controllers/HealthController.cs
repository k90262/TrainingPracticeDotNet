using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

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
        public ActionResult BMI(BMIModel obj)
        {
            double h = obj.Height / 100;
            obj.BMI = obj.Weight / h / h;
            return View(obj);
        }
    }
}