using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        Database1Entities db = new Database1Entities();
        public ActionResult Index()
        {
            return View(db.Products);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product obj)
        {
            db.Products.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var obj = db.Products.Find(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Edit(int id, Product obj)
        {
            obj.ProductID = id;
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var obj = db.Products.Find(id);
            db.Products.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}