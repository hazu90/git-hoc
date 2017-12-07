using CF.BL;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var cityCrawlerBL = new CityCrawlerBL();
            //cityCrawlerBL.GetData();

            var locationCrawlerBL = new LocationCrawlerBL();
            locationCrawlerBL.GenerateLocationDetailFile();
        }
    }
}
