﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    [Authorize]
    public class LocationController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }
    }
}
