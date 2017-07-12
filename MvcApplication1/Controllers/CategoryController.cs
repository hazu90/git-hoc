using MvcApplication1.Business;
using MvcApplication1.Models;
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
            var categoryGroupBAL = new CategoryGroupBAL();
            var lstCateGroup = categoryGroupBAL.GetAll();

            var categoryBAL = new CategoryBAL();
            var lstCategory = categoryBAL.GetAll();

            var model = new AllCategoryModel();
            model.LstCategory = lstCategory;
            model.LstCategoryGroup = lstCateGroup;
            return View(model);
        }
    }
}
