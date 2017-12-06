using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Models
{
    public class LocationCrawlerModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string HrefLink { get; set; }
        public string ImageLink { get; set; }
        public string AddressDescription { get; set; }
    }
}
