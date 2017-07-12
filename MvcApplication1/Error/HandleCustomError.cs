using HelperLib;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Error
{
    public class HandleCustomError : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //Nếu exception đã được xử lý thì không làm gì nữa
            if (filterContext.ExceptionHandled)
            {
                return;
            }
            else
            {
                //Định nghĩa kiểu trả về của action
                string actionName = filterContext.RouteData.Values["action"].ToString();
                Type controllerType = filterContext.Controller.GetType();
                var method = controllerType.GetMethod(actionName);
                var returnType = method.ReturnType;

                //Nếu là Json
                if (returnType.Equals(typeof(JsonResult)))
                {
                    filterContext.Result = new JsonResult()
                    {
                        Data = new ResponseModel() { Code = SystemStatusCode.Error.GetHashCode(), Message = filterContext.Exception.Message }
                    };
                }

                //Nếu là view
                if (returnType.Equals(typeof(ActionResult))
                || (returnType).IsSubclassOf(typeof(ActionResult)))
                {
                    var model = new HandleErrorInfo(filterContext.Exception, filterContext.RouteData.Values["controller"].ToString(), actionName);
                    filterContext.Result = new ViewResult()
                    {
                        ViewName = "/views/common/errorpage.cshtml",
                        ViewData = new ViewDataDictionary(model)
                    };
                }
            }
            //Đánh dấu các exception đã được handled
            filterContext.ExceptionHandled = true;
        }
    }
}