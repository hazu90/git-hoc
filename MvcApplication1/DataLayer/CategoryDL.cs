using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class CategoryDL
    {
        public List<CategoryModel> GetAll()
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("Category_GetAll")
                                .QueryMany<CategoryModel>();
            }
        }
    }
}