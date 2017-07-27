using MvcApplication1.DataLayer;
using MvcApplication1.Models;
using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class LocationBAL
    {
        public ResponseModel Create(LocationForCreateModel model)
        {
            var response = new ResponseModel();
            var locationDL = new LocationDL();
            // 
            var yyyy = DateTime.Now.Year;
            var mm = DateTime.Now.Month;
            var dd = DateTime.Now.Day;
            model.OpenTime = new DateTime(yyyy,mm,dd,model.HourOpenTime,model.MinuteOpenTime,0);
            model.ClosedTime = new DateTime(yyyy, mm, dd, model.HourClosedTime, model.MinuteClosedTime, 0);
            model.LastClientInTime = new DateTime(yyyy, mm, dd, model.HourLastClientInTime, model.MinuteLastClientInTime, 0);

            locationDL.Create(new Location()
            {
                LocationName = model.LocationName,
                Address = model.Address,
                CategoryGrId = model.CategoryGrId,
                CountryId = model.CountryId,
                CityId = model.CityId,
                ProvinceId = model.ProvinceId,
                NearBy = model.NearBy,
                AddressDescription = model.AddressDescription,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                WebsiteUrl = model.WebsiteUrl,
                Description =model.Description,
                NumberOfPersonInRoom = model.NumberOfPersonInRoom.GetValueOrDefault(0) ,
                OpenTime = model.OpenTime,
                ClosedTime =model.ClosedTime,
                LastClientInTime = model.LastClientInTime,
                MinCost =model.MinCost,
                MaxCost =model.MaxCost,
                LanguageUsed = model.LanguageUsed,
                CreatedBy = model.CreatedBy
            });
            return response;
        }
    }
}