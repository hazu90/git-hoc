﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeafoodEntity
{
    public class UserInformation
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public string CityCode { get; set; }
        public int Status { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Description { get; set; }
        public bool IsPrivate { get; set; }
        public string Yahoo { get; set; }
        public string FacebookUrl { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
    }
}
