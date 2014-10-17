using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using WebsitePinger.Models;

namespace WebsitePinger
{
    public class SitemapPinger
    {
        public SitemapPinger()
        {
            string[] urls = new string[] {
                "http://whereshouldibuy.apphb.com/sitemap/Index",
            };

            using (var client = new WebClient())
            {
                client.Proxy = new WebProxy("http://10.49.1.1:8080");
                foreach (var url in urls)
                {
                    //var response = client.DownloadString(url);

                    using (var reader = client.OpenRead(url))
                    {
                        var s = new XmlSerializer(typeof(Sitemap[]));
                        var index = (SitemapIndex)s.Deserialize(reader);

                        Console.WriteLine("num sitemaps -> " + index.Sitemaps.Length);

                    }
                }

            }
        }
    }
}
