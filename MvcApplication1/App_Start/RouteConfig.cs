using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(name: "LoginUrl",url: "dang-nhap",defaults: new { controller = "Account", action = "Login"});
            routes.MapRoute(name: "RegisterUrl",url: "dang-ky",defaults: new { controller = "Account", action = "Register" });
            routes.MapRoute(name: "ForgotPasswordUrl",url: "quen-mat-khau",defaults: new { controller = "Account", action = "ForgotPassword" });
            routes.MapRoute(name: "AddLocation",url: "them-dia-diem",defaults: new { controller = "Location", action = "Create" });
            routes.MapRoute(name: "UserInformationUrl", url: "tai-khoan", defaults: new { controller = "UserInformation", action = "Edit" });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}