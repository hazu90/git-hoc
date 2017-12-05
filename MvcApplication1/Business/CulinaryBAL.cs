using MvcApplication1.DataLayer;
using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class CulinaryBAL
    {
        public List<Culinary> GetAll()
        {
            return (new CulinaryDAL()).GetAll();
        }
    }
}