using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using System.Net;

namespace ConsoleApp1
{
    class FoodSiteParser
    {
        public string GetLine(string URL)
        {
            WebClient client = new WebClient();
            string pageContent = client.DownloadString(URL);
            return pageContent;
        }
    }
}
