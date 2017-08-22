using MvcApplication1.DataLayer;
using MvcApplication1.Models;
using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class UserInformationBAL
    {
        /// <summary>
        /// Add a new userinformation
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Create(UserInformation model)
        {
            var userInformationDAL = new UserInformationDAL();
            userInformationDAL.Insert(model);
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public UserInformation GetByUserName(string userName)
        {
            var userInformationDAL = new UserInformationDAL();
            return userInformationDAL.GetByUserName(userName);
        }

        public ResponseModel CreateAnonymous()
        {

            return new ResponseModel();
        }
    }

}