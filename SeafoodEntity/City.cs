﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeafoodEntity
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public string LocationLink { get; set; }
        public int CountryId { get; set; }
    }
}
