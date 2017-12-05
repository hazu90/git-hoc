using FluentData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.DAL
{
    public class ConnectionDB
    {
        public static IDbContext MainDB()
        {
            return new DbContext().ConnectionString(ConfigurationManager.ConnectionStrings["DbSeaFoody"].ConnectionString, new SqlServerProvider());
        }
    }
}
