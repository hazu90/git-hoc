﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class CategoryModel
    {
        public int CateId { get; set; }
        public string CateName { get; set; }
        public string CateLink { get; set; }
        public int CateGrId { get; set; }
        public string IconImgUrl { get; set; }
    }
}