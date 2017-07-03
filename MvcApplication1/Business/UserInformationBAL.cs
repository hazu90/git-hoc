using MvcApplication1.DataLayer;
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
    }

}