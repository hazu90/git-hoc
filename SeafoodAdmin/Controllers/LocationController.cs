using HelperLib;
using SeafoodAdmin.Business;
using SeafoodAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeafoodAdmin.Controllers
{
    public class LocationController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(LocationForSearchModel model)
        {
            var locationBL = new LocationBL();
            return View(locationBL.GetList(model));
        }

        public JsonResult Approve(int id)
        {
            var response = new ResponseModel();
            var locationBL = new LocationBL();
            locationBL.Appove(id);
            response.Code = SystemStatusCode.Success.GetHashCode();
            response.Message = "Bạn đã duyệt thông tin địa điểm thành công !";
            return Json(response, JsonRequestBehavior.AllowGet);
        }

    }
}