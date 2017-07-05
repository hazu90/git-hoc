using HelperLib;
using Newtonsoft.Json;
using SeafoodAPI.Business;
using SeafoodAPI.IServices;
using SeafoodAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SeafoodAPI
{
    public class City : ICity
    {
        public ResponseModel Create(RequestModel model)
        {
            var response = new ResponseModel();
            var cityBL = new CityBL();
            return cityBL.Create(model.Data);
        }
        public ResponseModel Update(RequestModel model)
        {
                var cityBL = new CityBL();
            return cityBL.Update(model.Data);
        }
    }
}
