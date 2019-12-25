using MVC_SQLITE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_SQLITE.Controllers
{
    public class DBENTRYController : Controller
    {
        // GET: DBENTRY
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getData()
        {
            using(DBContext dc = new DBContext())
            {
                var userlist = dc.USERs.ToList<USER>();
                return Json(new { rows = userlist }, JsonRequestBehavior.AllowGet);
            }
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
    }
}