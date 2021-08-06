using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StringQueryApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Welcome2()
        {
            return Content(Request.QueryString["developer"]);
        }
    }
}