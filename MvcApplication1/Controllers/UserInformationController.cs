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

            var model = userInfoBAL.GetByUserName(userName);
            return View(new UserInformationForEditModel() { 
                            UserName = model.UserName,
                            FirstName = model.FirstName,
                            LastName = model.LastName,
                            UserEmail = model.UserEmail,
                            CityCode = model.CityCode,
                            Status = model.Status
                            
                        });
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public JsonResult Edit(UserInformationForEditModel model)
        {
            var response = new ResponseModel();
            return Json(response, JsonRequestBehavior.DenyGet);
        }
    }
}
