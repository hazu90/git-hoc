﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using MvcApplication1.Filters;
using MvcApplication1.Models;
using MvcApplication1.Common;
using Newtonsoft.Json;
using MvcApplication1.DataLayer;

namespace MvcApplication1.Controllers
{
    //[Authorize]
    //[InitializeSimpleMembership]
    //public class AccountController : Controller
    //{
    //    [AllowAnonymous]
    //    public ActionResult Login(string returnUrl)
    //    {
    //        ViewBag.ReturnUrl = returnUrl;
    //        return View();
    //    }

    //    [HttpPost]
    //    [AllowAnonymous]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Login(LoginModel model, string returnUrl)
    //    {
    //        if (ModelState.IsValid && WebSecurity.Login(model.UserName, model.Password, persistCookie: model.RememberMe))
    //        {
    //            return RedirectToLocal(returnUrl);
    //        }

    //        // If we got this far, something failed, redisplay form
    //        ModelState.AddModelError("", "The user name or password provided is incorrect.");
    //        return View(model);
    //    }

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult LogOff()
    //    {
    //        WebSecurity.Logout();

    //        return RedirectToAction("Index", "Home");
    //    }

    //    [AllowAnonymous]
    //    public ActionResult Register()
    //    {
    //        return View();
    //    }

    //    [HttpPost]
    //    [AllowAnonymous]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Register(RegisterModel model)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            // Attempt to register the user
    //            try
    //            {
    //                WebSecurity.CreateUserAndAccount(model.UserName, model.Password);
    //                WebSecurity.Login(model.UserName, model.Password);
    //                return RedirectToAction("Index", "Home");
    //            }
    //            catch (MembershipCreateUserException e)
    //            {
    //                ModelState.AddModelError("", ErrorCodeToString(e.StatusCode));
    //            }
    //        }

    //        // If we got this far, something failed, redisplay form
    //        return View(model);
    //    }

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Disassociate(string provider, string providerUserId)
    //    {
    //        string ownerAccount = OAuthWebSecurity.GetUserName(provider, providerUserId);
    //        ManageMessageId? message = null;

    //        // Only disassociate the account if the currently logged in user is the owner
    //        if (ownerAccount == User.Identity.Name)
    //        {
    //            // Use a transaction to prevent the user from deleting their last login credential
    //            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.Serializable }))
    //            {
    //                bool hasLocalAccount = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
    //                if (hasLocalAccount || OAuthWebSecurity.GetAccountsFromUserName(User.Identity.Name).Count > 1)
    //                {
    //                    OAuthWebSecurity.DeleteAccount(provider, providerUserId);
    //                    scope.Complete();
    //                    message = ManageMessageId.RemoveLoginSuccess;
    //                }
    //            }
    //        }

    //        return RedirectToAction("Manage", new { Message = message });
    //    }

    //    //
    //    // GET: /Account/Manage

    //    public ActionResult Manage(ManageMessageId? message)
    //    {
    //        ViewBag.StatusMessage =
    //            message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
    //            : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
    //            : message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
    //            : "";
    //        ViewBag.HasLocalPassword = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
    //        ViewBag.ReturnUrl = Url.Action("Manage");
    //        return View();
    //    }

    //    //
    //    // POST: /Account/Manage

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Manage(LocalPasswordModel model)
    //    {
    //        bool hasLocalAccount = OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
    //        ViewBag.HasLocalPassword = hasLocalAccount;
    //        ViewBag.ReturnUrl = Url.Action("Manage");
    //        if (hasLocalAccount)
    //        {
    //            if (ModelState.IsValid)
    //            {
    //                // ChangePassword will throw an exception rather than return false in certain failure scenarios.
    //                bool changePasswordSucceeded;
    //                try
    //                {
    //                    changePasswordSucceeded = WebSecurity.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword);
    //                }
    //                catch (Exception)
    //                {
    //                    changePasswordSucceeded = false;
    //                }

    //                if (changePasswordSucceeded)
    //                {
    //                    return RedirectToAction("Manage", new { Message = ManageMessageId.ChangePasswordSuccess });
    //                }
    //                else
    //                {
    //                    ModelState.AddModelError("", "The current password is incorrect or the new password is invalid.");
    //                }
    //            }
    //        }
    //        else
    //        {
    //            // User does not have a local password so remove any validation errors caused by a missing
    //            // OldPassword field
    //            ModelState state = ModelState["OldPassword"];
    //            if (state != null)
    //            {
    //                state.Errors.Clear();
    //            }

    //            if (ModelState.IsValid)
    //            {
    //                try
    //                {
    //                    WebSecurity.CreateAccount(User.Identity.Name, model.NewPassword);
    //                    return RedirectToAction("Manage", new { Message = ManageMessageId.SetPasswordSuccess });
    //                }
    //                catch (Exception e)
    //                {
    //                    ModelState.AddModelError("", e);
    //                }
    //            }
    //        }

    //        // If we got this far, something failed, redisplay form
    //        return View(model);
    //    }

    //    //
    //    // POST: /Account/ExternalLogin

    //    [HttpPost]
    //    [AllowAnonymous]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult ExternalLogin(string provider, string returnUrl)
    //    {
    //        return new ExternalLoginResult(provider, Url.Action("ExternalLoginCallback", new { ReturnUrl = returnUrl }));
    //    }

    //    //
    //    // GET: /Account/ExternalLoginCallback

    //    [AllowAnonymous]
    //    public ActionResult ExternalLoginCallback(string returnUrl)
    //    {
    //        AuthenticationResult result = OAuthWebSecurity.VerifyAuthentication(Url.Action("ExternalLoginCallback", new { ReturnUrl = returnUrl }));
    //        if (!result.IsSuccessful)
    //        {
    //            return RedirectToAction("ExternalLoginFailure");
    //        }

    //        if (OAuthWebSecurity.Login(result.Provider, result.ProviderUserId, createPersistentCookie: false))
    //        {
    //            return RedirectToLocal(returnUrl);
    //        }

    //        if (User.Identity.IsAuthenticated)
    //        {
    //            // If the current user is logged in add the new account
    //            OAuthWebSecurity.CreateOrUpdateAccount(result.Provider, result.ProviderUserId, User.Identity.Name);
    //            return RedirectToLocal(returnUrl);
    //        }
    //        else
    //        {
    //            // User is new, ask for their desired membership name
    //            string loginData = OAuthWebSecurity.SerializeProviderUserId(result.Provider, result.ProviderUserId);
    //            ViewBag.ProviderDisplayName = OAuthWebSecurity.GetOAuthClientData(result.Provider).DisplayName;
    //            ViewBag.ReturnUrl = returnUrl;
    //            return View("ExternalLoginConfirmation", new RegisterExternalLoginModel { UserName = result.UserName, ExternalLoginData = loginData });
    //        }
    //    }

    //    //
    //    // POST: /Account/ExternalLoginConfirmation

    //    [HttpPost]
    //    [AllowAnonymous]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult ExternalLoginConfirmation(RegisterExternalLoginModel model, string returnUrl)
    //    {
    //        string provider = null;
    //        string providerUserId = null;

    //        if (User.Identity.IsAuthenticated || !OAuthWebSecurity.TryDeserializeProviderUserId(model.ExternalLoginData, out provider, out providerUserId))
    //        {
    //            return RedirectToAction("Manage");
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            // Insert a new user into the database
    //            using (UsersContext db = new UsersContext())
    //            {
    //                UserProfile user = db.UserProfiles.FirstOrDefault(u => u.UserName.ToLower() == model.UserName.ToLower());
    //                // Check if user already exists
    //                if (user == null)
    //                {
    //                    // Insert name into the profile table
    //                    db.UserProfiles.Add(new UserProfile { UserName = model.UserName });
    //                    db.SaveChanges();

    //                    OAuthWebSecurity.CreateOrUpdateAccount(provider, providerUserId, model.UserName);
    //                    OAuthWebSecurity.Login(provider, providerUserId, createPersistentCookie: false);

    //                    return RedirectToLocal(returnUrl);
    //                }
    //                else
    //                {
    //                    ModelState.AddModelError("UserName", "User name already exists. Please enter a different user name.");
    //                }
    //            }
    //        }

    //        ViewBag.ProviderDisplayName = OAuthWebSecurity.GetOAuthClientData(provider).DisplayName;
    //        ViewBag.ReturnUrl = returnUrl;
    //        return View(model);
    //    }

    //    //
    //    // GET: /Account/ExternalLoginFailure

    //    [AllowAnonymous]
    //    public ActionResult ExternalLoginFailure()
    //    {
    //        return View();
    //    }

    //    [AllowAnonymous]
    //    [ChildActionOnly]
    //    public ActionResult ExternalLoginsList(string returnUrl)
    //    {
    //        ViewBag.ReturnUrl = returnUrl;
    //        return PartialView("_ExternalLoginsListPartial", OAuthWebSecurity.RegisteredClientData);
    //    }

    //    [ChildActionOnly]
    //    public ActionResult RemoveExternalLogins()
    //    {
    //        ICollection<OAuthAccount> accounts = OAuthWebSecurity.GetAccountsFromUserName(User.Identity.Name);
    //        List<ExternalLogin> externalLogins = new List<ExternalLogin>();
    //        foreach (OAuthAccount account in accounts)
    //        {
    //            AuthenticationClientData clientData = OAuthWebSecurity.GetOAuthClientData(account.Provider);

    //            externalLogins.Add(new ExternalLogin
    //            {
    //                Provider = account.Provider,
    //                ProviderDisplayName = clientData.DisplayName,
    //                ProviderUserId = account.ProviderUserId,
    //            });
    //        }

    //        ViewBag.ShowRemoveButton = externalLogins.Count > 1 || OAuthWebSecurity.HasLocalAccount(WebSecurity.GetUserId(User.Identity.Name));
    //        return PartialView("_RemoveExternalLoginsPartial", externalLogins);
    //    }

    //    #region Helpers
    //    private ActionResult RedirectToLocal(string returnUrl)
    //    {
    //        if (Url.IsLocalUrl(returnUrl))
    //        {
    //            return Redirect(returnUrl);
    //        }
    //        else
    //        {
    //            return RedirectToAction("Index", "Home");
    //        }
    //    }

    //    public enum ManageMessageId
    //    {
    //        ChangePasswordSuccess,
    //        SetPasswordSuccess,
    //        RemoveLoginSuccess,
    //    }

    //    internal class ExternalLoginResult : ActionResult
    //    {
    //        public ExternalLoginResult(string provider, string returnUrl)
    //        {
    //            Provider = provider;
    //            ReturnUrl = returnUrl;
    //        }

    //        public string Provider { get; private set; }
    //        public string ReturnUrl { get; private set; }

    //        public override void ExecuteResult(ControllerContext context)
    //        {
    //            OAuthWebSecurity.RequestAuthentication(Provider, ReturnUrl);
    //        }
    //    }

    //    private static string ErrorCodeToString(MembershipCreateStatus createStatus)
    //    {
    //        // See http://go.microsoft.com/fwlink/?LinkID=177550 for
    //        // a full list of status codes.
    //        switch (createStatus)
    //        {
    //            case MembershipCreateStatus.DuplicateUserName:
    //                return "User name already exists. Please enter a different user name.";

    //            case MembershipCreateStatus.DuplicateEmail:
    //                return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

    //            case MembershipCreateStatus.InvalidPassword:
    //                return "The password provided is invalid. Please enter a valid password value.";

    //            case MembershipCreateStatus.InvalidEmail:
    //                return "The e-mail address provided is invalid. Please check the value and try again.";

    //            case MembershipCreateStatus.InvalidAnswer:
    //                return "The password retrieval answer provided is invalid. Please check the value and try again.";

    //            case MembershipCreateStatus.InvalidQuestion:
    //                return "The password retrieval question provided is invalid. Please check the value and try again.";

    //            case MembershipCreateStatus.InvalidUserName:
    //                return "The user name provided is invalid. Please check the value and try again.";

    //            case MembershipCreateStatus.ProviderError:
    //                return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

    //            case MembershipCreateStatus.UserRejected:
    //                return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

    //            default:
    //                return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
    //        }
    //    }
    //    #endregion
    //}

    public class AccountController : Controller
    {
        public ActionResult LogOn()
        {
            return View();
        }
        //, bool remember = false
        [HttpPost]
        public ActionResult LogOn(string username, string password, string returnUrl)
        {
            var userDL = new UserDL();
            //Get user with user and password user just entry
            var checkedUser = userDL.GetUserSecurity(username, password);
            var response = new LogonViewModel();
            if (checkedUser != null)
            {
                //If User deactive then return view 
                //if (!checkedUser.Status.Equals(UserState.Active.ToInt(-1)))
                if (!checkedUser.Status.Equals(UserState.Active))
                {
                    return View("~/Views/Common/ErrorManual.cshtml", null, "Tài khoản Admin  của bạn đã bị khóa. Vui lòng đăng nhập tài khoản khác hoặc ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
                }
                else
                {
                    if (checkedUser.LockedStartDate != null)
                    {
                        var dateLock = checkedUser.LockedStartDate.Value.AddMinutes(checkedUser.LockTime);
                        if (dateLock >= DateTime.Now)
                        {
                            return View("~/Views/Common/ErrorManual.cshtml", null, "Tài khoản của bạn đã bị khóa. Vui lòng đăng nhập tài khoản khác hoặc ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
                        }
                    }
                }

                // Lấy danh sách các role của người dùng vừa đăng nhập
                var userRoleDL = new UserRoleDL();
                var lstRoles = userRoleDL.GetByUserName(checkedUser.UserName);
                checkedUser.PermissionRoles = new List<int>();
                foreach (var roleInfo in lstRoles)
                {
                    checkedUser.PermissionRoles.Add(roleInfo.RoleId);
                }
                FormsAuthentication.SetAuthCookie(JsonConvert.SerializeObject(checkedUser, Formatting.None), false);
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                response = new LogonViewModel
                {
                    UserName = username,
                    Password = password,
                    Status = 1
                };
                return View(response);
            }
        }

        //public ActionResult LogOnSSO(string data)
        //{
        //    try
        //    {
        //        if (data.Length > 50)
        //        {
        //            //Login thành công SSO
        //            string token = ConfigurationManager.AppSettings["TokenSSO"];
        //            string dataDeCript = Libs.CryptorEngine.Decrypt(data, token);
        //            string[] arrDataLogin = dataDeCript.Split('#');
        //            string hashCode = Libs.CryptoEngine.MD5Encrypt(arrDataLogin[1] + arrDataLogin[2] + token);

        //            if (arrDataLogin[3] == hashCode)
        //            {
        //                var status = arrDataLogin[0];
        //                if (status == "100")
        //                {
        //                    var username = arrDataLogin[1];
        //                    if (!string.IsNullOrEmpty(username))
        //                    {
        //                        try
        //                        {
        //                            var userBL = new UserDL();
        //                            var user = userBL.GetByUserNameWithLockTime(username.Split(',')[0]);
        //                            if (user != null)
        //                            {

        //                                if (!user.Status.Equals(1))
        //                                {
        //                                    //Tài khoản bị khóa
        //                                    return View("~/Views/Common/ErrorManual.cshtml", null, "Tài khoản Admin  của bạn đã bị khóa. Vui lòng đăng nhập tài khoản khác hoặc ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
        //                                }
        //                                else
        //                                {
        //                                    if (user.LockedStartDate != null)
        //                                    {
        //                                        var dateLock = user.LockedStartDate.Value.AddMinutes(user.LockTime);
        //                                        if (dateLock >= DateTime.Now)
        //                                        {
        //                                            return View("~/Views/Common/ErrorManual.cshtml", null, "Tài khoản của bạn đã bị khóa. Vui lòng đăng nhập tài khoản khác hoặc ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
        //                                        }
        //                                    }
        //                                    // Lấy danh sách các role của người dùng vừa đăng nhập
        //                                    var userRoleDL = new UserRoleDL();
        //                                    var lstRoles = userRoleDL.GetByUserName(user.UserName);
        //                                    user.PermissionRoles = new List<int>();
        //                                    foreach (var roleInfo in lstRoles)
        //                                    {
        //                                        user.PermissionRoles.Add(roleInfo.RoleId);
        //                                    }

        //                                    FormsAuthentication.SetAuthCookie(
        //                                            JsonConvert.SerializeObject(user, Formatting.None).Encrypt(), true);
        //                                    return RedirectToAction("Index", "Home");
        //                                }
        //                            }
        //                            else
        //                            {
        //                                //Không tồn tại user ở db 
        //                                return View("~/Views/Common/ErrorManual.cshtml", null, "Tài khoản không tồn tại trên hệ thống Admin . Ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
        //                            }
        //                        }
        //                        catch (Exception exx)
        //                        {
        //                            return View("~/Views/Common/ErrorManual.cshtml", null, "Có lỗi xảy ra khi đăng nhập hệ thống Admin : " + exx.Message + "<br /> Ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        //Thông tin đăng nhập không chính xác
        //                        return View("~/Views/Common/ErrorManual.cshtml", null, "Tài khoản không tồn tại trên hệ thống Admin . Ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
        //                    }
        //                }
        //                else
        //                {
        //                    //Thông tin đăng nhập không chính xác
        //                    return View("~/Views/Common/ErrorManual.cshtml", null, "Thông tin đăng nhập SSO không chính xác. Ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
        //                }
        //            }
        //            else
        //            {
        //                return View("~/Views/Common/ErrorManual.cshtml", null, "Có lỗi xảy ra khi đăng nhập hệ thống SSO. Ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
        //            }
        //        }
        //        else if (data == "101")
        //        {
        //            //Tài khoản chưa được map với 
        //            return View("~/Views/Common/ErrorManual.cshtml", null, "Tài khoản SSO chưa được kết nối với tài khoản Admin . Liên hệ IT hoặc ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
        //        }
        //        else
        //        {
        //            //Tài khoản không tồn tại trên hệ thống SSO
        //            return View("~/Views/Common/ErrorManual.cshtml", null, "Có lỗi khi đăng nhập hệ thống SSO. Ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return View("~/Views/Common/ErrorManual.cshtml", null, "Có lỗi xảy ra khi đăng nhập: " + ex.Message + "<br /> Ấn vào <a href='/Account/LogOff'>đây</a> để đăng nhập lại!");
        //    }
        //}

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            //return Redirect(ConfigurationManager.AppSettings["LogOffUrl"]);
            return Redirect("/Account/LogOn");
        }
    }
}
