using MvcApplication1.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class LogonViewModel
    {
        [Required(ErrorMessage = "Bạn vui lòng điền tên đăng nhập!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bạn vui lòng điền mật khẩu")]
        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }
        public bool RememberMe { get; set; }
        public int Status { get; set; }
        public LogonViewModel()
        {
            UserName = "";
            Password = "";
            RememberMe = false;
            Status = 0;
        }
    }
    public class UserIndexModel
    {
        public string UserName { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalRecord { get; set; }
        public List<UserModel> LstUser { get; set; }
        public UserIndexModel()
        {
            PageIndex = 1;
            PageSize = 25;
            LstUser = new List<UserModel>();
        }
    }
    public class UserLockModel
    {
        public string UserName { get; set; }
        public DateTime LockedStartDate { get; set; }
        public int LockTime { get; set; }
    }
}