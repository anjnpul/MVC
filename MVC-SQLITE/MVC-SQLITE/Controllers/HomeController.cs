using MVC_SQLITE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_SQLITE.Controllers
{
    public class HomeController : Controller
    {
        DBContext dc = new DBContext();
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
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(USER e)
        {
            using (dc)
            {
                dc.USERs.Add(e);
                dc.SaveChanges();
            }
            return RedirectToAction("List");
        }
        public ActionResult login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult login(USER l, string ReturnUrl = "")
        {
                var user = dc.USERs.Where(a => a.USERN.Equals(l.USERN) && a.PASS.Equals(l.PASS)).FirstOrDefault();
                if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(user.USERN, false);
                        if (Url.IsLocalUrl(ReturnUrl))
                            {
                                return Redirect(ReturnUrl);
                            }

                        else
                            {
                                return RedirectToAction("Index", "DBENTRY");
                            }
                    }
            return View();
        }
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("login", "Home");
        }
    }
}