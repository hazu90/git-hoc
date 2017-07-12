using MvcApplication1.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CategoryController : Controller
    {
        [AllowAnonymous]
        [ChildActionOnly]
        public ActionResult GetAll()
        {
            var categoryBAL = new CategoryBAL();
            var lstCategory = categoryBAL.GetAll();
            return View(lstCategory);
        }
    }
}
