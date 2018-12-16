using NexusServiceEproject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NexusServiceEproject.Controllers
{
    public class RegisteruserController : Controller
    {
        tbl_loginEntities1 db = new tbl_loginEntities1();

        //
        // GET: /Registeruser/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Regiter()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Regiter(tbl_usersignup u, HttpPostedFileBase imgfile)
        {
            try
            {


             string s = uploadimgfile(imgfile);
                if (s.Equals("-1"))
                {
                    Response.Write("<script> alert('Image uploading failed......') <script>");
                }
                else
                {
                    tbl_usersignup ur = new tbl_usersignup();
                    ur.u_name = u.u_name;
                    ur.u_Eamil = u.u_Eamil;
                    ur.u_Password = u.u_Password;
                    ur.Conform_Password = u.Conform_Password;
                    ur.Image = s;
                    ur.u_Contact = u.u_Contact;

                    db.tbl_usersignup.Add(ur);
                    db.SaveChanges();

                   
                    return RedirectToAction("Index","Home");
                   
                }
                Response.Write("<script> alert('Registeration Successfull') <script>");

            }
            catch (Exception)
            {




                //throw;
            }
            return View();
        }

       // =====================================
        public string uploadimgfile(HttpPostedFileBase file)
        {
            Random r = new Random();
            string path = "-1";
            int random = r.Next();
            if (file != null && file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName);
                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png"))
                {
                    try
                    {

                        path = Path.Combine(Server.MapPath("~/Content/img"), random + Path.GetFileName(file.FileName));
                        file.SaveAs(path);
                        path = "~/Content/img/" + random + Path.GetFileName(file.FileName);

                        //    ViewBag.Message = "File uploaded successfully";
                    }
                    catch (Exception )
                    {
                        path = "-1";
                    }
                }
                else
                {
                    Response.Write("<script>alert('Only jpg ,jpeg or png formats are acceptable....'); </script>");
                }
            }

            else
            {
                Response.Write("<script>alert('Please select a file'); </script>");
                path = "-1";
            }



            return path;
        }

    }
}