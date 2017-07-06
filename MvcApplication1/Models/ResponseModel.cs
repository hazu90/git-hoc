using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ResponseModel
    {
        public int Code { get; set; }
        public dynamic Data { get; set; }
        public string Message { get; set; }
    }
}