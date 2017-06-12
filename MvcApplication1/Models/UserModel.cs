using MvcApplication1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public DateTime? LockedStartDate { get; set; }
        public int LockTime { get; set; }
        public int Status { get; set; }
        public int Role { get; set; }
        public string UserRoles { get; set; }
        public List<int> PermissionRoles { get; set; }
        public bool HasPermisson(Permission permission)
        {
            if (PermissionRoles.FindAll(o => o == permission.GetHashCode()).Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}