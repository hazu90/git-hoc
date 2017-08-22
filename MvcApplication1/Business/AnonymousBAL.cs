using MvcApplication1.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class AnonymousBAL
    {
        /// <summary>
        /// Sinh username cho các người dùng đăng kí mà không có thông tin về email
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        public string GenerateUserNameWithoutEmail()
        {
            var userInformationDAL = new UserInformationDAL();
            var lastestUserAnonymous = userInformationDAL.GetLastestAnonymous();
            var index_user = "0000001";
            if (lastestUserAnonymous == null)
            {
                return "ff_anonymous" + index_user;
            }
            else
            {
                var idx = lastestUserAnonymous.UserName.Replace("ff_anonymous", "");
                var iIdx = int.Parse(idx);
                iIdx++;
                if (iIdx < 10)
                {
                    idx = "000000" + iIdx.ToString();
                }
                else if (iIdx < 100)
                {
                    idx = "00000" + iIdx.ToString();
                }
                else if (iIdx < 1000)
                {
                    idx = "0000" + iIdx.ToString();
                }
                else if (iIdx < 10000)
                {
                    idx = "000" + iIdx.ToString();
                }
                else if (iIdx < 100000)
                {
                    idx = "00" + iIdx.ToString();
                }
                return idx;
            }
        }
    }
}