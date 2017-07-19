using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class AreaModel
    {
        public List<City> LstCity { get; set; }
        public List<Country> LstCountry { get; set; }
        public List<District> LstDistrict { get; set; }
    }
}