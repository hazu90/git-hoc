using SeafoodAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeafoodAdmin.Controllers
{
    public class CommonController : Controller
    {
        public ActionResult Paging(PagerModel pager)
        {
            return View(pager);
        }

        public ActionResult Header()
        {
            //ViewBag.CurentUser = UserContext;
            return View();
        }

        public ActionResult Sidebar()
        {
            return View();
        }
    }
}