using CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.DAL
{
    public class LocationCrawlerDL
    {
        public void Insert(LocationCrawlerModel model)
        {
            using (var context = ConnectionDB.MainDB())
            {
                context.StoredProcedure("LocationCrawler_Insert")
                        .Parameter("Name", model.Name)
                        .Parameter("ImageLink", model.ImageLink)
                        .Parameter("HrefLink", model.HrefLink)
                        .Parameter("AddressDescription", model.AddressDescription)
                        .Execute();
            }
        }
    }
}
