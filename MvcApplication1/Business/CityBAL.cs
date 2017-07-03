using MvcApplication1.DataLayer;
using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class CityBAL
    {
        /// <summary>
        /// Lấy tất cả danh sách thành phố trong cả nước
        /// </summary>
        /// <returns></returns>
        public List<City> GetAll()
        {
            var cityDL = new CityDL();
            return cityDL.GetAll();
        }
    }
}