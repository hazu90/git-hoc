using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class DistrictDL
    {
        public List<District> GetAll()
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("District_GetAll")
                                .QueryMany<District>();
            }
        }
    }
}