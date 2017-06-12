using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Common
{
    public enum UserState
    {
        Active = 1,
        InActive = 2
        //    ,
        //Deleted =3
    }

    public enum Permission
    {
        /// <summary>
        /// Quyền nhân viên
        /// </summary>
        Employee = 0,
        /// <summary>
        /// Quyền của người quản lý
        /// </summary>
        Manager = 1,
        /// <summary>
        /// Quyền của Admin
        /// </summary>
        Admin = 2,
        /// <summary>
        /// Quyền quản lý khách mời
        /// </summary>
        InviteeManager = 3
    }
}