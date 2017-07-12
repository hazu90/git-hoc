using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class CategoryGroupDL
    {
        public List<CategoryGroupModel> GetAll()
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("CategoryGroup_GetAll")
                                .QueryMany<CategoryGroupModel>();
            }
        }
    }
}