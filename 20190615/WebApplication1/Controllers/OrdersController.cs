using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrdersController : Controller
    {
        Database1Entities db = new Database1Entities();
        public ActionResult Index()
        {
            return View(db.Orders);
        }

        public ActionResult Create()
        {
            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "Name");
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name");
            ViewBag.Price = db.Products.First().Price;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Order obj, string btnAdd)
        {
            if (btnAdd == null)
            {
                ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "Name");
                ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name");
                ViewBag.Price = db.Products.Find(obj.ProductID).Price;
                return View(obj);
            }
            else
            {
                db.Orders.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int id)
        {
            var obj = db.Orders.Find(id);

            ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "Name", obj.CustomerID);
            ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name", obj.ProductID);
            ViewBag.Price = obj.Price;

            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(int id, Order obj, string btnUpdate)
        {
            if (btnUpdate == null)
            {
                ViewBag.CustomerID = new SelectList(db.Customers, "CustomerID", "Name");
                ViewBag.ProductID = new SelectList(db.Products, "ProductID", "Name");
                ViewBag.Price = db.Products.Find(obj.ProductID).Price;
                return View(obj);
            }
            else
            {
                obj.OrderID = id;
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int id)
        {
            var obj = db.Orders.Find(id);
            db.Orders.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}