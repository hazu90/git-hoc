using MvcApplication1.Business;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    [Authorize]
    public class LocationController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(LocationForCreateModel model)
        {
            if (ModelState.IsValid)
            {
                var locationBL = new LocationBAL();
                locationBL.Create(model);
                // Gửi thông báo thêm mới thành công đến người dùng
                var successInfo = new LocationSuccessForCreateModel();
                successInfo.LocationName = model.LocationName;
                return View("CreateSuccess",successInfo);
            }
            return View();
        }
    }
}
