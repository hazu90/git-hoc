using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace MvcApplication1.Business
{
    public class GoogleCaptchaBAL
    {
        /// <summary>
        /// Xac thuc request la tu nguoi dung
        /// </summary>
        /// <returns></returns>
        public bool Authenticate(string googleRequest)
        {
            var secretKey = "6Lfu7R4UAAAAAH1aPC7FCVjwasR6jH3me1PBg8-5";
            var client = new WebClient();
            var urlReQuest = string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, googleRequest);
            var result = client.DownloadString(urlReQuest);
            var obj = JsonConvert.DeserializeObject<dynamic>(result);
            return (bool)obj.SelectToken("success");
        }
    }
}