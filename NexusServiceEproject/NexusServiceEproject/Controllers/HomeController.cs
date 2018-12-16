using NexusServiceEproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace NexusServiceEproject.Controllers
{
    public class HomeController : Controller
    {
        tbl_loginEntities1 db = new tbl_loginEntities1();
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
        
            //[HttpGet]
        //public ActionResult Registration()
        //{
          
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Registration(tbl_usersignup u)
        //{
        //    tbl_usersignup user = new tbl_usersignup();
        //    user.u_name = u.u_name;
        //    user.u_Eamil = u.u_Eamil;
        //    user.u_Password = u.u_Password;
        //    user.Conform_Password = u.Conform_Password;
        //    db.tbl_usersignup.Add(u);
        //    db.SaveChanges();
        //    return View(u);
        //}

        //[HttpGet]
        //public ActionResult Registr()
        //{
          
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Registr(tbl_usersignup u)
        //{
        //    tbl_usersignup ui = new tbl_usersignup();
        //    ui.u_name = u.u_name;
        //    ui.u_Eamil = u.u_Eamil;
        //    ui.u_Password = u.u_Password;
        //    ui.Conform_Password = u.Conform_Password;
        //    db.tbl_usersignup.Add(u);
        //    db.SaveChanges();
             
        //    return View(u);
        //}



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
        
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["Valid"] = "Invalid user or Password";
                return RedirectToAction("Index", "Home");

            }
        
           
        }
        public ActionResult Confirm(int regID)
        {
            ViewBag.regID = regID;
            return View();
        
        }
      

        
    
        }

    }
