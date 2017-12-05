using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.BL
{
    public class CityCrawlerBL
    {
        public void GetData()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(@"D:\My Projects\ASP.NET\MVC\Seafood\git-hoc\CF\Data\html data\foody city link.txt");
            var htmlNode = document.DocumentNode.SelectNodes("//*[@id=\"popupLocation\"]/ul/li/ul/li[2]/ul/li/a").ToArray();

            foreach (var item in htmlNode)
            {
                var id = item.Attributes["data-id"].Value;
            }
        }
    }
}
