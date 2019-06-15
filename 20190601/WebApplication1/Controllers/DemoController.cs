using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DemoController : Controller
    {
        Database1Entities db = new Database1Entities();
        public ActionResult Index()
        {
            var result =
                from c in db.Customers
                join o in db.Orders on c.CustomerID equals o.CustomerID
                join p in db.Products on o.ProductID equals p.ProductID
                select new Demo() {
                     CustomerBirthday = c.Birthday,
                     CustomerName = c.Name,
                     ProductName = p.Name,
                     ListPrice = p.Price,
                     OrderDate = o.OrderDate,
                     Price = o.Price,
                     Quantity = o.Quantity
                };

            return View(result);
        }
    }
}