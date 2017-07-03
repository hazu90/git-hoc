using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class CityDL
    {
        public List<City> GetAll()
        {
            using(var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("City_GetAll")
                                .QueryMany<City>();
            }
        }
    }
}