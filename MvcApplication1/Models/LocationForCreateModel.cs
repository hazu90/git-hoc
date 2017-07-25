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
        [Required(ErrorMessage="Ten dia diem bat buoc nhap")]
        [MaxLength(100,ErrorMessage="Ten dia diem khong vuot qua 100 ki tu")]
        public string LocationName { get; set; }
        [Required(ErrorMessage = "Dia chi bat buoc nhap")]
        public string Address { get; set; }
        public int CategoryGrId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int ProvinceId { get; set; }
        public string NearBy { get; set; }
        public string AddressDescription { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage="Dia chi email khong dung")]
        public string Email { get; set; }
        public string WebsiteUrl { get; set; }
        public string Description { get; set; }
        public int? NumberOfPersonInRoom { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan ClosedTime { get; set; }
        public TimeSpan LastClientInTime { get; set; }
        public decimal MinCost { get; set; }
        public decimal MaxCost { get; set; }
        public int LanguageUsed { get; set; }
        public List<CategoryModel> LstCategory { get; set; }
        public List<CategoryGroupModel> LstCategoryGroup { get; set; }
    }
}