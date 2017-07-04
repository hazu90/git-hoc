using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace HelperLib
{
    public static class Helper
    {
        /// <summary>
        /// Loại bỏ thẻ tag html
        /// Remove html tag 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string TrimHtmlTags(this string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;
            input = HttpUtility.HtmlDecode(input);
            return Regex.Replace(input, @"<.[^>]*>", string.Empty);
        }
        /// <summary>
        /// Chuyển chuỗi có dấu sang không dấu
        /// Convert signed string to unsigned string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToVietNameseChacracter(this string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty);
        }
        /// <summary>
        /// Kiểm tra xem chuỗi dữ liệu truyền vào có phải email hay không
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidMail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            string sMailPattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            return Regex.IsMatch(email.Trim(), sMailPattern);
        }
        /// <summary>
        /// Gửi POST request đến url
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static WebResponse SendPostRequest(string url,string data,string contentType="application/x-www-form-urlencoded")
        {
            var httpRequest = HttpWebRequest.Create(url);
            httpRequest.Method = "POST";
            httpRequest.ContentType =contentType ;
            httpRequest.ContentLength = data.Length;
            var streamWriter = new StreamWriter(httpRequest.GetRequestStream());
            streamWriter.Write(data);
            streamWriter.Close();
            return httpRequest.GetResponse();
        }
        /// <summary>
        /// Gửi GET request đến url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static WebResponse SendGetRequest(string url)
        {
            var httpRequest = HttpWebRequest.Create(url);
            httpRequest.Method = "GET";
            return httpRequest.GetResponse();
        }
    }
}
