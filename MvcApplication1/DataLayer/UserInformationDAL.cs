using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class UserInformationDAL
    {
        public void Insert(UserInformation model)
        {
            using(var context = ConnectionDB.MainDB())
            {
                context.StoredProcedure("UserInformation_Insert")
                        .Parameter("FirstName", model.FirstName)
                        .Parameter("LastName", model.LastName)
                        .Parameter("UserEmail", model.UserEmail)
                        .Parameter("UserName", model.UserName)
                        .Parameter("CityCode", model.CityCode)
                        .Execute();
            }
        }

        public UserInformation GetByUserName(string userName)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("UserInformation_GetByUserName")
                        .Parameter("UserEmail",userName )
                        .QuerySingle<UserInformation>();
            }
        }

        public void UpdateConfirmEmail(string userName)
        {
            using (var context = ConnectionDB.MainDB())
            {
                context.StoredProcedure("UserInformation_UpdateConfirmedEmailAndActive")
                        .Parameter("UserEmail", userName)
                        .Execute();
            }
        }
    }
}