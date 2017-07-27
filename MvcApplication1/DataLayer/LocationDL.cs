using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class LocationDL
    {
        public int Create(Location model)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("Location_Create")
                                .Parameter("LocationName", model.LocationName)
                                .Parameter("Address", model.Address)
                                .Parameter("CategoryGrId", model.CategoryGrId)
                                .Parameter("CountryId", model.CountryId)
                                .Parameter("CityId", model.CityId)
                                .Parameter("ProvinceId", model.ProvinceId)
                                .Parameter("NearBy", model.NearBy)
                                .Parameter("AddressDescription", model.AddressDescription)
                                .Parameter("PhoneNumber", model.PhoneNumber)
                                .Parameter("Email", model.Email)
                                .Parameter("WebsiteUrl", model.WebsiteUrl)
                                .Parameter("Description", model.Description)
                                .Parameter("NumberOfPersonInRoom", model.NumberOfPersonInRoom)
                                .Parameter("OpenTime", model.OpenTime)
                                .Parameter("ClosedTime", model.ClosedTime)
                                .Parameter("LastClientInTime", model.LastClientInTime)
                                .Parameter("MinCost", model.MinCost)
                                .Parameter("MaxCost", model.MaxCost)
                                .Parameter("LanguageUsed", model.LanguageUsed)
                                .Parameter("CreatedBy", model.CreatedBy)
                                .QuerySingle<int>();
            }
        }
    }
}