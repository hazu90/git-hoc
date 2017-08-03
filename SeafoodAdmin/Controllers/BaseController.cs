using SeafoodAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeafoodAdmin.Controllers
{
    public class BaseController:Controller
    {
        private CurrentUserModel UserContext{get;set;}
        public BaseController()
        {
            
            //WebSecurity.
        }

    }
}