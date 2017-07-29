using SeafoodAdmin.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeafoodAdmin.Controllers
{
    public class AccountController : Controller
    {
        [Authorize]
        [InitializeSimpleMembership]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogOn()
        {
            return View();
        }
    }
}