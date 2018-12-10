using NexusServiceEproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NexusServiceEproject.Controllers
{
    public class HomeController : Controller
    {
        tbl_loginEntities db = new tbl_loginEntities();
        public ActionResult Index()
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

        public ActionResult Pay()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult bbhome()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult products()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Packs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ReportIssues()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult logout()
        {
            Session.RemoveAll();
            Session.Abandon();
            TempData.Remove("username");

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult login(tbl_usersignup user)
        {
            tbl_usersignup u = db.tbl_usersignup.Where(x => x.u_Eamil == user.u_Eamil && x.u_Password == user.u_Password).SingleOrDefault();
            if (u != null)
            {
                Session["u_id"] = u.u_id;
                TempData["username"] = u.u_name;
                TempData.Keep();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Valid"] = "Invalid user or Password";
            }
            TempData.Keep();


            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}