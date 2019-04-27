using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer obj)
        {
            return View(obj);
        }
    }
}