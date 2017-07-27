using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeafoodEntity
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public int CategoryGrId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int ProvinceId { get; set; }
        public string NearBy { get; set; }
        public string AddressDescription { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WebsiteUrl { get; set; }
        public string Description { get; set; }
        public int NumberOfPersonInRoom { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? ClosedTime { get; set; }
        public DateTime? LastClientInTime { get; set; }
        public decimal? MinCost { get; set; }
        public decimal? MaxCost { get; set; }
        public int? LanguageUsed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
