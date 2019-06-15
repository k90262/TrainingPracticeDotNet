using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomersController : Controller
    {
        Database1Entities db = new Database1Entities();
        public ActionResult Index()
        {
            return View(db.Customers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer obj)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View(obj);
        }

        public ActionResult Edit(int id)
        {
            var obj = db.Customers.Find(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(int id, Customer obj)
        {
            obj.CustomerID = id;
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var obj = db.Customers.Find(id);
            db.Customers.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}