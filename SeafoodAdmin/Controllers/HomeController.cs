using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace SeafoodAdmin.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]

        public ActionResult Index()
        {
            if (WebSecurity.IsAuthenticated)
            {
                return View();
            }
            else
            {
               return RedirectToAction("Login", "Account");
            }
            
        }
    }
}