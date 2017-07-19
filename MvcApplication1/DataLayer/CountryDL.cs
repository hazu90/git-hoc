using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class CountryDL
    {
        public List<Country> GetAll() 
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("Country_GetAll")
                                .QueryMany<Country>();
            }
        }
    }
}