using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class CulinaryDAL
    {
        public List<Culinary> GetAll()
        {
            using (var context = ConnectionDB.MainDB())
            {
                return context.StoredProcedure("Culinary_GetAll")
                                .QueryMany<Culinary>();
            }
        }
    }
}