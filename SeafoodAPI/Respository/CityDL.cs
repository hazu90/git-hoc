using SeafoodAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeafoodAPI.Respository
{
    public class CityDL
    {
        public void Create(CityModel model)
        {
            using(var context = ConnectionDB.MainDB())
            {
                context.StoredProcedure("City_Create")
                                .Parameter("CityName", model.CityName)
                                .Parameter("CityCode", model.CityCode)
                                .Execute();
            }
        }
        public void Update(CityModel model)
        {
            using (var context = ConnectionDB.MainDB())
            {
                context.StoredProcedure("City_Update")
                                .Parameter("Id", model.Id)
                                .Parameter("CityName", model.CityName)
                                .Parameter("CityCode", model.CityCode)
                                .Execute();
            }
        }
    }
}