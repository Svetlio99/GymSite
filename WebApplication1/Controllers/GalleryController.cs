using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vgym.Controllers
{
    public class GalleryController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Галерия";

            return View();
        }

        public ActionResult Fitness()
        {
            return View("Fitness");
        }

        public ActionResult Spa()
        {
            return View("Spa");
        }
        public ActionResult Pool()
        {
            return View("Pool");
        }
        public ActionResult Solarium()
        {
            return View("Solarium");
        }
        public ActionResult Icaros()
        {
            return View("Icaros");

        }
        public ActionResult Massages()
        {
            return View("Massages");
        }
	}
}