using E_voting_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_voting_System.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        private ElectionEntities db = new ElectionEntities();

        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View(new Admin());
        }


        // POST: Account/Login
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            if (ModelState.IsValid)
            {
                var user = db.Admins.FirstOrDefault(u => u.Email == admin.Email && u.Password == admin.Password);

                if (user != null)
                {
                    Session["AdminId"] = user.ID;
                    Session["AdminName"] = user.Name;

                    return RedirectToAction("LocalResult", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password.");
                }
            }

            return View(admin);
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
    }
}