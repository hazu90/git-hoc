using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class LocationForDetailModel
    {
        public int Id { get; set; }
        public string RepImgLink { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string WardName { get; set; }
        public string LocationName { get; set; }
        /// <summary>
        /// Điểm chất lượng
        /// </summary>
        public double QuanlityScore { get; set; }
        /// <summary>
        /// Điểm địa chỉ
        /// </summary>
        public double AddressScore { get; set; }
        /// <summary>
        /// Điểm phục vụ
        /// </summary>
        public double ServiceScore { get; set; }
        /// <summary>
        /// Điểm không gian
        /// </summary>
        public double AreaScore { get; set; }
        /// <summary>
        /// Điểm về giá cả
        /// </summary>
        public double CostScore { get; set; }

        public string Address { get; set; }
    }
}