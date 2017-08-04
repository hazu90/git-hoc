using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeafoodAdmin.Models
{
    public class BreadcumbModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<BreadcumbItemModel> LstSubBreadcumbLink { get; set; }
    }

    public class BreadcumbItemModel
    {
        public string Name { get; set; }
        public string Link { get; set; }
    }
}