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
        public static string SendPostRequest(string url,string data,string contentType="application/x-www-form-urlencoded")
        {
            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create(url);
            // Set the Method property of the request to POST.
            request.Method = "POST";
            // Create POST data and convert it to a byte array.
            string postData = data;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = contentType;
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse webResponse = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)webResponse).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = webResponse.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            webResponse.Close();
            return responseFromServer;
        }
        /// <summary>
        /// Gửi GET request đến url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string SendGetRequest(string url, string data, string contentType = "application/x-www-form-urlencoded")
        {
            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create(url);
            // Set the Method property of the request to POST.
            request.Method = "GET";
            // Create POST data and convert it to a byte array.
            string postData = data;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = contentType;
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse webResponse = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)webResponse).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = webResponse.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            webResponse.Close();
            return responseFromServer;
        }
    }
}
