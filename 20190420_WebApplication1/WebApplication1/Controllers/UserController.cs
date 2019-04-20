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
        public ActionResult Login(string username, string passwordj)
        //public ActionResult Login(LoginModel obj)
        {
            return RedirectToAction("LoginResult");
        }

        public ActionResult LoginResult()
        {
            return View();
        }
    }
}