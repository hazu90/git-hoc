using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //if (UserContext != null)
            //{
            //    return View();
            //}
            //return RedirectToAction("LogOn", "Account");
            return View();
        }

        //public ActionResult About()
        //{
        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    return View();
        //}
    }
}
