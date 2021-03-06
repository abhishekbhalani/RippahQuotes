﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RippahQuotes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Quotes");
        }
        // About Page Unused
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        // About Page Unused
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}