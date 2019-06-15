using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Demo2Controller : Controller
    {
        Database1Entities db = new Database1Entities();
        public ActionResult Index()
        {
            return View(db.MyDatas);
        }
    }
}