using MvcApplication1.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MvcApplication1.Controllers
{
    public class CityController : Controller
    {
        [AllowAnonymous]
        [ChildActionOnly]
        [OutputCache(Duration = 86400)]
        public ActionResult GetAllCity()
        {
            var cityBAL = new CityBAL();
            var lstCity = cityBAL.GetAll();
            return View(lstCity);
        }
    }
}
