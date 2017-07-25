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
                LanguageUsed = model.LanguageUsed
            });
            return response;
        }
    }
}