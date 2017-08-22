using HelperLib;
using Microsoft.Web.WebPages.OAuth;
using MvcApplication1.Business;
using MvcApplication1.Models;
using Oauth2Login.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ExternalAccountController : Controller
    {
        public ActionResult Login(string id, AuthExternalMode? mode)
        {
            var service = BaseOauth2Service.GetService(id);

            if (service != null)
            {
                var url = service.BeginAuthentication();

                if (mode.HasValue)
                    TempData["AuthExternalMode"] = mode;

                return Redirect(url);
            }
            else
            {
                return RedirectToAction("LoginFail");
            }
        }

        public ActionResult Callback(string id)
        {
            var service = BaseOauth2Service.GetService(id);

            if (service != null)
            {
                try
                {
                    var redirectUrl = service.ValidateLogin(Request);
                    if (redirectUrl != null)
                    {
                        return Redirect(redirectUrl);
                    }
                    // Lấy thông tin người dùng đăng nhập qua ứng dụng xã hội
                    var userInfo = service.UserData;
                    var userName = "";
                    // TH người dùng đăng kí không có thông tin về email
                    if (string.IsNullOrEmpty(userInfo.Email))
                    {
                        userName = (new AnonymousBAL()).GenerateUserNameWithoutEmail();
                    }
                    else
                    {
                        userName = EmailHelper.GetUserNameOfEmail(userInfo.Email);
                    }

                    string provider = "";
                    if (userInfo.AuthService == Oauth2Login.Core.ExternalAuthServices.Facebook)
                    {
                        provider = "Facebook";
                    }
                    else if(userInfo.AuthService == Oauth2Login.Core.ExternalAuthServices.Google)
                    {
                        provider = "Google";
                    }

                    if (OAuthWebSecurity.Login(provider, userInfo.UserId, createPersistentCookie: false))
                    {
                        return Redirect("/Home/Index");
                    }

                    if (User.Identity.IsAuthenticated)
                    {
                        OAuthWebSecurity.CreateOrUpdateAccount(provider, userInfo.UserId, User.Identity.Name);
                        return Redirect("/Home/Index");
                    }
                    else
                    {
                        using (UsersContext db = new UsersContext())
                        {
                            var user = db.UserProfiles.FirstOrDefault(u => u.UserName.ToLower() == userName);
                            // Check if user already exists
                            if (user == null)
                            {
                                // Insert name into the profile table
                                db.UserProfiles.Add(new UserProfile { UserName = userName });
                                db.SaveChanges();

                                OAuthWebSecurity.CreateOrUpdateAccount(provider, service.UserData.UserId, userName);
                                OAuthWebSecurity.Login(provider, service.UserData.UserId, createPersistentCookie: false);

                                return Redirect("/Home/Index");
                            }
                            else
                            {
                                
                                ModelState.AddModelError("UserName", "User name already exists. Please enter a different user name.");
                                return Redirect("/Home/Index");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                    //RedirectToAction("Error");
                }
            }
            else
            {
                return RedirectToAction("LoginFail");
            }
        }

        public ActionResult LoginFail()
        {
            return View();
        }

        public ActionResult LoginSuccess()
        {
            return View();
        }

    }
}
