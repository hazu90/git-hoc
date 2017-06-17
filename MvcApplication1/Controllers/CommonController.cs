using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CommonController : BaseController
    {
        public ActionResult Paging(PagerModel pager)
        {
            return View(pager);
        }

        public ActionResult Header()
        {
            ViewBag.CurentUser = UserContext;
            return View();
        }
        [HttpGet]
        [FilterAuthorize]
        public virtual ActionResult Download(string fileGuid, string fileName)
        {
            if (TempData[fileGuid] != null)
            {
                byte[] data = TempData[fileGuid] as byte[];
                if (TempData.ContainsKey(fileGuid))
                {
                    TempData.Remove(fileGuid);
                }
                return File(data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
            }
            else
            {
                return new EmptyResult();
            }
        }

    }
}
