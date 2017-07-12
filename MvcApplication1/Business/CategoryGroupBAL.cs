using MvcApplication1.DataLayer;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class CategoryGroupBAL
    {
        public List<CategoryGroupModel> GetAll()
        {
            var cateGroupDL = new CategoryGroupDL();
            return cateGroupDL.GetAll();
        }
    }
}