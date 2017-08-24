using MvcApplication1.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace MvcApplication1.Controllers
{
    [Authorize]
    public class UserInformationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UpdateInfo()
        {
            return View();
        }

        public ActionResult Edit()
        {
            var userName= WebSecurity.CurrentUserName;
            //Lấy thông tin của user
            var userInfoBAL = new UserInformationBAL();
            var userInfo = userInfoBAL.GetByUserName(userName);

            return View();
        }
    }
}
