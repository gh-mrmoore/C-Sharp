using System;
using System.IO;
using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage(string url)
        {
            //WebClient client = new WebClient();
            //string reply = client.DownloadString(url);

            //return client.DownloadString(url);

            //Console.WriteLine(reply);
            //File.WriteAllText(@"C:\Users\mrm\Documents\Code\_C-Sharp\Course_LC101\CodeLibrary.txt", reply);

            return GetWebPage(url);

        }

        public string ScrapeWebPage(string url, string filepath)
        {
            //WebClient client = new WebClient();
            //string reply = client.DownloadString(url);
            string reply = GetWebPage(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
