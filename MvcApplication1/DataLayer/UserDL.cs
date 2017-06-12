using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class UserDL
    {
        public UserModel GetUserSecurity(string userName, string password)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("User_GetByUserNamePassword")
                              .Parameter("UserName", userName)
                              .Parameter("Password", password)
                              .QuerySingle<UserModel>();
            }
        }
        public UserIndexModel GetList(UserIndexModel model)
        {
            using (var context = ConnectionDB.MainDB())
            {
                var cmd = context.StoredProcedure("User_GetList")
                              .Parameter("UserName", model.UserName)
                              .Parameter("PageIndex", model.PageIndex)
                              .Parameter("PageSize", model.PageSize)
                              .ParameterOut("TotalRecord", FluentData.DataTypes.Int32);
                var result = cmd.QueryMany<UserModel>();
                model.LstUser = result;
                model.TotalRecord = cmd.ParameterValue<int>("TotalRecord");
                return model;
            }
        }
        public void Delete(string userName)
        {
            using (var context = ConnectionDB.MainDB())
            {
                context.StoredProcedure("User_Delete")
                              .Parameter("UserName", userName)
                              .Execute();
            }
        }
        public void ChangeStatus(string userName, int status)
        {
            using (var context = ConnectionDB.MainDB())
            {
                context.StoredProcedure("User_ChangeStatus")
                              .Parameter("UserName", userName)
                              .Parameter("Status", status)
                              .Execute();
            }
        }
        public bool Insert(UserModel model)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("User_Insert")
                              .Parameter("UserName", model.UserName)
                              .Parameter("PassWord", model.PassWord)
                              .Parameter("Role", model.Role)
                              .QuerySingle<int>() > 0;
            }
        }
        public bool Update(UserModel model)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("User_Update")
                              .Parameter("UserName", model.UserName)
                              .Parameter("PassWord", model.PassWord)
                              .Parameter("Role", model.Role)
                              .QuerySingle<int>() > 0;
            }
        }
        public UserModel GetByUserName(string userName)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("User_GetByUserName")
                    .Parameter("UserName", userName)
                    .QuerySingle<UserModel>();
            }
        }
        public UserModel GetByUserNameWithLockTime(string userName)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("User_GetByUserNameWithLockTime")
                    .Parameter("UserName", userName)
                    .QuerySingle<UserModel>();
            }
        }
        public bool LockUserTemporarily(UserLockModel model)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("User_LockTemporary")
                        .Parameter("LockTime", model.LockTime)
                        .Parameter("LockedStartDate", model.LockedStartDate)
                        .Parameter("UserName", model.UserName)
                        .QuerySingle<int>() > 0;
            }
        }
        public bool UnLockUserTemporarily(string userName)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("User_UnLockTemporary")
                                .Parameter("UserName", userName)
                                .QuerySingle<int>() > 0;
            }
        }
    }
}