﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vgym.Controllers
{
    public class PoolController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.title = "Басейн";

            return View();
        }
	}
}