using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DD_Shoes.Models;

namespace DD_Shoes.Controllers
{
    public class RegisterController : Controller
    {
        RegisterEntities db = new RegisterEntities();
        // GET: Register
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (db.Users.Any(x => x.User_Name == user.User_Name))
            {
                ViewBag.Notification = "This account a been already existed";

                return View();
            }
            else
            {
                db.Users.Add(user);
                db.SaveChanges();

                Session["User_IDS"] = user.User_ID.ToString();
                Session["User_NameS"] = user.User_Name.ToString();
                return RedirectToAction("Index","Register");
            }

        }
        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Index", "Register");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login(User user)
        {
            var checklogin = db.Users.Where(x => x.User_Name.Equals(user.User_Name) && x.Password.Equals(user.Password)).FirstOrDefault();
       if (checklogin != null)
            {
                Session["User_IDS"] = user.User_ID.ToString();
                Session["User_NameS"] = user.User_Name.ToString();
                return RedirectToAction("Index", "Register");
            }
       else
            {
                ViewBag.Notification = "Wrong Username or Password";
            }
            return View();
        }
    }
}
