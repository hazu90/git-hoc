using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class LocationForDetailModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Ảnh đại diện của địa điểm
        /// </summary>
        public string RepImgLink { get; set; }
        /// <summary>
        /// Tên thành phố
        /// </summary>
        public string CityName { get; set; }
        /// <summary>
        /// Link thành phố
        /// </summary>
        public string CityLink { get; set; }
        /// <summary>
        /// Tên quận , huyện
        /// </summary>
        public string DistrictName { get; set; }
        /// <summary>
        /// Link quận huyện
        /// </summary>
        public string DistrictLink { get; set; }
        /// <summary>
        /// Tên phường xã
        /// </summary>
        public string WardName { get; set; }
        /// <summary>
        /// Link phường xã
        /// </summary>
        public string WardLink { get; set; }

        /// <summary>
        /// Tên địa điểm
        /// </summary>
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
        /// <summary>
        /// Địa chỉ quán
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Thời gian mở quán
        /// </summary>
        public DateTime? OpenTime { get; set; }
        /// <summary>
        /// Thời gian đóng quán
        /// </summary>
        public DateTime? ClosedTime { get; set; }
        
        public decimal? MinCost { get; set; }

        public decimal? MaxCost { get; set; }

        public string HrefLink { get; set; }
        /// <summary>
        /// Số lượt xem
        /// </summary>
        public int ViewCount { get; set; }
        /// <summary>
        /// Tên loại hình địa điểm
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// Link các địa điểm có loại hình liên quan
        /// </summary>
        public string CategoryLink { get; set; }
        /// <summary>
        /// Tên ẩm thực của địa điểm
        /// </summary>
        public string CulinaryName { get; set; }
        /// <summary>
        /// Link của loại ẩm thực đó
        /// </summary>
        public string CulinaryLink { get; set; }

        public string OrientedCustomer { get; set; }
    }
}