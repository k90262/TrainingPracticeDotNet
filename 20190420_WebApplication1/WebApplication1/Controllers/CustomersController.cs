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

        // GET: Customers
        public ActionResult Index()
        {
            //return View(db.Customers);
            return View(db.Customers);
        }

        // GET: Customers
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer obj)
        {
            db.Customers.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Customer c = db.Customers.Find(id);
            // 要自己判斷C存不存在
            db.Customers.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Customer c = db.Customers.Find(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(int id, Customer obj)
        {
            obj.CustomerID = id;
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}