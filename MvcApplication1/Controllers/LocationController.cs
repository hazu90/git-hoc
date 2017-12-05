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
    public class LocationController : Controller
    {
        public ActionResult Create()
        {
            return View(new LocationForCreateModel()
            {
                LstCategory = (new CategoryBAL()).GetAll(),
                LstCategoryGroup = (new CategoryGroupBAL()).GetAll(),
            });
        }
        [HttpPost]
        public ActionResult Create(LocationForCreateModel model)
        {
            if (ModelState.IsValid)
            {
                // Lấy ra thông tin của người tạo địa điểm
                model.CreatedBy = WebSecurity.CurrentUserName;
                // Tạo mới địa điểm
                (new LocationBAL()).Create(model);
                // Gửi thông báo thêm mới thành công đến người dùng
                return View("CreateSuccess", new LocationSuccessForCreateModel() { 
                    LocationName = model.LocationName
                });
            }   

            model.LstCategory = (new CategoryBAL()).GetAll();
            model.LstCategoryGroup = (new CategoryGroupBAL()).GetAll();

            return View(model);
        }

        [AllowAnonymous]
        public ActionResult GetByCity(string cityUrl)
        {
            return View();
        }
    }
}
