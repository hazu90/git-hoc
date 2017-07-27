using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class LocationForCreateModel
    {
        public int LocationId { get; set; }
        [Required(ErrorMessage="Tên địa điểm bắt buộc nhập")]
        [MaxLength(100,ErrorMessage="Tên địa điểm không vượt quá 100 kí tự")]
        public string LocationName { get; set; }
        [Required(ErrorMessage = "Địa chỉ bắt buộc nhập")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Loại hình bắt buộc nhập")]
        public int CategoryGrId { get; set; }
        [Required(ErrorMessage = "Đất nước bắt buộc nhập")]
        public int CountryId { get; set; }
        [Required(ErrorMessage = "Thành phố bắt buộc nhập")]
        public int CityId { get; set; }
        [Required(ErrorMessage = "Quận huyện bắt buộc nhập")]
        public int ProvinceId { get; set; }
        public string NearBy { get; set; }
        public string AddressDescription { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage="Địa chỉ email không đúng")]
        public string Email { get; set; }
        public string WebsiteUrl { get; set; }
        public string Description { get; set; }
        public int? NumberOfPersonInRoom { get; set; }
        public int HourOpenTime { get; set; }
        public int MinuteOpenTime { get; set; }
        public DateTime? OpenTime { get; set; }
        public int HourClosedTime { get; set; }
        public int MinuteClosedTime { get; set; }
        public DateTime? ClosedTime { get; set; }
        public int HourLastClientInTime { get; set; }
        public int MinuteLastClientInTime { get; set; }
        public DateTime? LastClientInTime { get; set; }
        public decimal MinCost { get; set; }
        public decimal MaxCost { get; set; }
        public int LanguageUsed { get; set; }
        public List<CategoryModel> LstCategory { get; set; }
        public List<CategoryGroupModel> LstCategoryGroup { get; set; }
        public string CreatedBy { get; set; }
    }
}