using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearningHub.Model;


namespace LearningHub.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        LearningHubDBContext db = new LearningHubDBContext();
        // GET: Admin/Home
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(tbl_Admin obj)
        {
            var LogInCheck = db.tbl_Admin.Where(x => x.AdminId.Equals(obj.AdminId) && x.Password.Equals(obj.Password)).FirstOrDefault();
            if (LogInCheck != null)
            {
                Session["AdminId"] = obj.AdminId.ToString();
                Session["AdminName"] = LogInCheck.AdminName.ToString();
                return RedirectToAction("Landing");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid Admin ID/Password";
                return View();
            }

        }

        public ActionResult Landing()
        {
            return View();
        }
        public ActionResult LogOut()
        {
            Session.Clear();
            Session.Abandon();
            return View("Login");
        }
    }
}