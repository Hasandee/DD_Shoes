using DD_Shoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DD_Shoes.Controllers
{
    public class HomeController : Controller
    {
        loginEntities db = new loginEntities();

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Login(User log)
        {
            var user = db.Users.Where(x => x.User_Name == log.User_Name && x.Password == log.Password).Count();
            if (user > 0)
            {
                return RedirectToAction("Index", "Register");
            }
            else
            {
                return View();
            }
        }


        public ActionResult Index()
        {
            return View();
        }

    } 
}