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
    }
}