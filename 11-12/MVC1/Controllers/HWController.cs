﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{
    public class HWController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hi()
        {
            return View();
        }
    }
}