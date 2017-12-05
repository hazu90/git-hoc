using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.BL
{
    public class LocationCrawlerBL
    {
        public void GetData()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(@"D:\My Projects\ASP.NET\MVC\Seafood\git-hoc\CF\Data\html data\foody discovery link.txt");
            var htmlNode = document.DocumentNode.SelectNodes("//*[@id=\"ajaxRequestDiv\"]/div/div[2]/div").ToArray();

            foreach (var item in htmlNode)
            {
                var childNodes= item.SelectNodes("//*[@class=\"items-content\"]/div[2]/a").First();
                //var id = item.Attributes["data-id"].Value;
            }
        }
    }
}
