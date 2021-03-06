﻿using HelperLib;
using MvcApplication1.DataLayer;
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

        /// <summary>
        /// activate account after gegister
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="tokenKey"></param>
        /// <returns></returns>
        public ResponseModel Activate(string userName,string tokenKey)
        {
            var response = new ResponseModel();
            // Kiểm tra tính hợp lệ của token

            // authenticate with token key    
            var userInformationDL = new UserInformationDAL();
            var userInfo = userInformationDL.GetByUserName(userName);
            if (userInfo != null)
            {
                userInformationDL.UpdateConfirmEmail(userInfo.UserEmail);
                response.Code = SystemStatusCode.Success.GetHashCode();
                return response;
            }
            else
            {
                response.Code = SystemStatusCode.DataNull.GetHashCode() ;
                response.Message = "Không tìm thấy thông tin người dùng !";
                return response;
            }
        }
    }
}