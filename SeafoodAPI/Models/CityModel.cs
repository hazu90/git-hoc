using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SeafoodAPI.Models
{
    [DataContract]
    public class CityModel
    {
        [IgnoreDataMember]
        public int Id { get; set; }
        [DataMember]
        public string CityName { get; set; }
        [DataMember]
        public string CityCode { get; set; }
    }
}