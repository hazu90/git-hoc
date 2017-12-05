using MvcApplication1.Business;
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
            // Lấy danh sách các địa điểm nhà hàng
            var locationBL = new LocationBAL();
            var culinaryBL = new CulinaryBAL();
            ViewBag.AllCulinary = culinaryBL.GetAll();
            var lstLocation = locationBL.GetList();
            return View(lstLocation);
        }
        [AllowAnonymous]
        public ActionResult IsAuthenticated()
        {
            
            if (WebSecurity.IsAuthenticated)
            {
                var userInfo = new SignnedInUserModel();
                userInfo.UserName = WebSecurity.CurrentUserName;
                userInfo.IsLoggedIn = WebSecurity.IsAuthenticated;
                var userInformationBL = new UserInformationBAL();
                var currUserInfo = userInformationBL.GetByUserName(userInfo.UserName);
                if (currUserInfo != null)
                {
                    userInfo.UserEmail = currUserInfo.UserEmail;
                    userInfo.FirstName = currUserInfo.FirstName;
                    userInfo.LastName = currUserInfo.LastName;
                }
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
