using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class AllCategoryModel
    {
        public List<CategoryModel> LstCategory { get; set; }
        public List<CategoryGroupModel> LstCategoryGroup { get; set; }
    }
}