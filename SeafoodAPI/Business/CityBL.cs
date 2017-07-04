using HelperLib;
using Newtonsoft.Json;
using SeafoodAPI.Models;
using SeafoodAPI.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeafoodAPI.Business
{
    public class CityBL
    {
        CityDL CityDL;

        public CityBL(CityDL cityDL)
        {
            this.CityDL = cityDL;
        }
        public CityBL()
        {
            this.CityDL = new CityDL();
        }

        public ResponseModel Create(string jsonData)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<CityModel>(jsonData);
                var response = new ResponseModel();
                // Validate thông tin đầu vào
                if (string.IsNullOrEmpty(model.CityName))
                {
                    response.Code = SystemStatusCode.NotValid.GetHashCode();
                    response.Message = "Thông tin thành phố bắt buộc nhập";
                    return response;
                }
                CityDL.Create(model);
                response.Code = SystemStatusCode.Success.GetHashCode();
                response.Message = "Bạn đã thêm thành phố thành công";
                return response;
            }
            catch
            {
                return new ResponseModel() { 
                    Code = SystemStatusCode.Error.GetHashCode(),
                    Message="Có lỗi trong quá trình xử lý"
                };
            }
            
        }
    }
}