using MvcApplication1.DataLayer;
using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Business
{
    public class CountryBAL
    {
        public List<Country> GetAll()
        {
            return (new CountryDL()).GetAll();
        }
    }
}