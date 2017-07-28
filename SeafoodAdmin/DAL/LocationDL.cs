using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeafoodAdmin.DAL
{
    public class LocationDL
    {
        public List<Location> GetList()
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("Location_GetList")
                        .QueryMany<Location>();
            }
        }

        public bool Approve(int id)
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("Location_Approve")
                                .Parameter("LocationId", id)
                                .Execute()>0;
            }
        }
    }
}