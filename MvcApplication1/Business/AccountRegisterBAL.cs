using HelperLib;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class AccountRegisterBAL
    {
        public ResponseModel Register(RegisterInfoModel model)
        {
            var response = new ResponseModel();
            // Validate 1 số các thông tin
            //Họ và tên bắt buộc nhập
            if(string.IsNullOrEmpty(model.FirstName))
            {
                response.Code = SystemStatusCode.NotValid.GetHashCode();
                response.Message = "Tên của người dùng bắt buộc nhập";
            }
            if (string.IsNullOrEmpty(model.LastName))
            {
                response.Code = SystemStatusCode.NotValid.GetHashCode();
                response.Message = "Họ của người dùng bắt buộc nhập";
            }
            if (string.IsNullOrEmpty(model.UserEmail) || !Helper.IsValidMail(model.UserEmail))
            {
                response.Code = SystemStatusCode.NotValid.GetHashCode();
                response.Message = "Email của người dùng bắt buộc nhập";
            }
            return response;
        }
    }
}