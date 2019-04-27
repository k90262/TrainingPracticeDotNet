using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(LoginModel obj)
        {
            if (obj.username == "user1" && obj.password == "123")
                return RedirectToAction("LoginResult");
            else
                return View(obj);
        }

        public ActionResult LoginResult()
        {
            return View();
        }
    }
}