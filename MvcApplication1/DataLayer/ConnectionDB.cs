using FluentData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MvcApplication1.DataLayer
{
    public class ConnectionDB
    {
        public static IDbContext MainDB()
        {
            return new DbContext().ConnectionString(ConfigurationManager.AppSettings["DVSCheckIn"], new SqlServerProvider());
        }
    }
}