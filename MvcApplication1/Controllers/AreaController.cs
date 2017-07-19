using MvcApplication1.Business;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class AreaController : Controller
    {
        public JsonResult GetAll()
        {
            return Json(new AreaModel() {
                LstCity = (new CityBAL()).GetAll(),
                LstCountry = (new CountryBAL()).GetAll(),
                LstDistrict = (new DistrictBAL() ).GetAll()
            }, JsonRequestBehavior.AllowGet);
        }

    }
}
