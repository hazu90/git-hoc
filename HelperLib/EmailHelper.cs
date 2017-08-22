using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLib
{
    public class EmailHelper
    {
        /// <summary>
        /// Get username of email before @ symbol
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string GetUserNameOfEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return "";
            }
            else
            {
                return (email.Trim()).Split('@')[0];
            }
        }
    }
}
