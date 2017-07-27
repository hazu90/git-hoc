﻿using MvcApplication1.Business;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace MvcApplication1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult IsAuthenticated()
        {
            
            if (WebSecurity.IsAuthenticated)
            {
                var userInfo = new SignnedInUserModel();
                userInfo.UserName = WebSecurity.CurrentUserName;
                userInfo.IsLoggedIn = WebSecurity.IsAuthenticated;
                return PartialView("_AuthenticatedPartial",userInfo );
            }
            else
            {
                return PartialView("_AnonymousPartial");
            }
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        
    }
}
