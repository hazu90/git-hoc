using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class UserRoleModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
    }
}