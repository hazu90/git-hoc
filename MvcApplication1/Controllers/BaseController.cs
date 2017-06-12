using MvcApplication1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class BaseController : Controller
    {
        public UserModel UserContext
        {
            get { return GetCurrentUser(); }
        }

        private UserModel GetCurrentUser()
        {
            if (System.Web.HttpContext.Current == null) return null;
            var user = System.Web.HttpContext.Current.User;
            if (user == null)
            {
                return null;
            }
            if (!string.IsNullOrWhiteSpace(user.Identity.Name))
            {
                if (!string.IsNullOrWhiteSpace(user.Identity.Name))
                {
                    return JsonConvert.DeserializeObject<UserModel>(user.Identity.Name);
                }
            }
            return null;
        }
    }
    public class FilterAuthorize : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                var url = WebConfigurationManager.AppSettings["LoginUrl"] + "?return=" + HttpContext.Current.Request.Url.AbsolutePath;
                filterContext.Result = new RedirectResult(url);
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
