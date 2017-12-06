using CF.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.BL
{
    public class LocationCrawlerBL
    {
        public List<LocationCrawlerModel> GetData()
        {
            HtmlWeb web = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            HtmlAgilityPack.HtmlDocument document = web.Load(@""+ConfigurationManager.AppSettings["LocationDataLink"].ToString());
            var htmlNode = document.DocumentNode.SelectNodes("//*[@id=\"ajaxRequestDiv\"]/div/div[2]/div").ToArray();
            var lstLocationCrawler = new List<LocationCrawlerModel>();
            foreach (var item in htmlNode)
            {
                var node = item.SelectSingleNode("./div[@class=\"items-content\"]/div[2]/a");
                var descriptionNode = item.SelectSingleNode("./div[@class=\"items-content\"]/div[3]");
                var imgNode = item.SelectSingleNode("./div[@class=\"avatar\"]/a/img");
                if(node != null)
                {
                    var locationName = node.InnerText;
                    var hrefLink = node.Attributes["href"].Value;
                    var description = "";
                    if (descriptionNode != null)
                    {
                        description = descriptionNode.InnerText;
                    }
                    var imageLink = "";
                    if(imgNode != null )
                    {
                        imageLink = imgNode.Attributes["src"].Value;
                    }

                    lstLocationCrawler.Add(new LocationCrawlerModel()
                    {
                        Name = locationName,
                        HrefLink = hrefLink,
                        AddressDescription = description,
                        ImageLink = imageLink
                    });
                }
            }

            return lstLocationCrawler;
        }

        public void GenerateScriptSql()
        {
            var processDataBL = new ProcessDataBL();
            var lstLocationCrawler = GetData();
            using (var writer = new StreamWriter(ConfigurationManager.AppSettings["LocationScript"].ToString()))
            {
                foreach (var item in lstLocationCrawler)
                {
                    var sqlLine = string.Format("INSERT INTO [LocationCrawler]([Name],[HrefLink],[ImageLink],[AddressDescription]) VALUES(N'{0}',N'{1}',N'{2}',N'{3}') ", processDataBL.ProcessData(item.Name), processDataBL.ProcessData(item.HrefLink), processDataBL.ProcessData(item.ImageLink), processDataBL.ProcessData(item.AddressDescription));
                    writer.WriteLine(sqlLine);
                }
                writer.Flush();
            } 
        }
    }
}
