using MvcApplication1.DataLayer;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class CategoryBAL
    {
        public List<CategoryModel> GetAll()
        {
            var categotyDL = new CategoryDL();
            return categotyDL.GetAll();
        }
    }
}