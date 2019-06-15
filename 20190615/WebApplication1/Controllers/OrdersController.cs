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
        //[Authorize(Users="test1@test.org")]
        public ActionResult Create()
        {
            var obj = new OrderViewModel();
            obj.Customers = new SelectList(db.Customers, "CustomerID", "Name");
            obj.Products = new SelectList(db.Products, "ProductID", "Name");
            obj.Price = db.Products.First().Price;
            return View(obj);
        }

        [HttpPost]
        public ActionResult Create(OrderViewModel obj, string btnAdd)
        {
            if (btnAdd == null)
            {
                obj.Customers = new SelectList(db.Customers, "CustomerID", "Name");
                obj.Products = new SelectList(db.Products, "ProductID", "Name");
                obj.Price = db.Products.Find(obj.Order.ProductID).Price;
                return View(obj);
            }
            else
            {
                db.Orders.Add(obj.Order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
        //[Authorize(Users ="test2@test.org")]
        public ActionResult Edit(int id)
        {
            var obj = new OrderViewModel();
            obj.Order = db.Orders.Find(id);
            obj.Customers = new SelectList(db.Customers, "CustomerID", "Name", obj.Order.CustomerID);
            obj.Products = new SelectList(db.Products, "ProductID", "Name", obj.Order.ProductID);
            obj.Price = obj.Order.Price;

            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(int id, OrderViewModel obj, string btnUpdate)
        {
            if (btnUpdate == null)
            {
                obj.Customers = new SelectList(db.Customers, "CustomerID", "Name");
                obj.Products = new SelectList(db.Products, "ProductID", "Name");
                obj.Price = db.Products.Find(obj.Order.ProductID).Price;
                return View(obj);
            }
            else
            {
                obj.Order.OrderID = id;
                db.Entry(obj.Order).State = EntityState.Modified;
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