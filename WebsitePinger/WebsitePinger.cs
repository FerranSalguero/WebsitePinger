using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Diagnostics;

namespace WebsitePinger
{
    class WebsitePinger
    {
        public WebsitePinger()
        {
            string[] urls = new string[] {
                "http://raquelestrada.apphb.com/",
                "http://wmhomepage.apphb.com/",
                "http://twitter-stats.apphb.com/",
                "http://glimpse.apphb.com/WCFService.svc",
                "http://motivate.apphb.com"
            };

            using (var client = new WebClient())
            {
                foreach (var url in urls)
                {
                    try
                    {
                        client.DownloadData(new Uri(url));
                    }
                    catch (System.Exception ex)
                    {
                        Debug.WriteLine("Error pinging websites: ", ex.Message);
                        // TODO: Log to logentries
                    }
                }
            }

        }
    }
}
