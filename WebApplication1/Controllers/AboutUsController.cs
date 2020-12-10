using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vgym.Controllers
{
    public class AboutUsController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Title = "За нас";

            return View();
        }
	}
}