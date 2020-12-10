using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vgym.Controllers
{
    public class PricesController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Цени";

            return View();
        }
	}
}