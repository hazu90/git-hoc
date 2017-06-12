using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class UserRoleDL
    {
        public bool Insert(UserRoleModel model)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("UserRole_Insert")
                                .Parameter("UserName", model.UserName)
                                .Parameter("Role", model.RoleId)
                                .QuerySingle<int>() > 0;
            }
        }

        public List<UserRoleModel> GetByUserName(string userName)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("UserRole_GetByUserName")
                                .Parameter("UserName", userName)
                                .QueryMany<UserRoleModel>();
            }
        }

        public void Delete(int id)
        {
            using (var context = ConnectionDB.MainDB())
            {
                context.StoredProcedure("UserRole_Delete")
                        .Parameter("Id", id)
                        .Execute();
            }
        }
    }
}