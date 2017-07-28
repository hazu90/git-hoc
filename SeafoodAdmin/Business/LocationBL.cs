using SeafoodAdmin.DAL;
using SeafoodAdmin.Models;
using SeafoodEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeafoodAdmin.Business
{
    public class LocationBL
    {
        public List<Location>  GetList(LocationForSearchModel model)
        {
            return (new LocationDL()).GetList();
        }

        public bool Appove(int locationId)
        {
            return (new LocationDL()).Approve(locationId);
        }
    }
}