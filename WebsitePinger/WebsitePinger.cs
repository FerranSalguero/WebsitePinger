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
                "http://twitter-stats.apphb.com/"

            };

            try
            {
                var client = new WebClient();
                foreach (var url in urls)
                {
                    client.DownloadData(new Uri(url));
                }
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine("Error pinging websites: ", ex.Message);
                // TODO: Log to logentries
            }
        }

        static int Main(string[] args)
        {
            new WebsitePinger();

            return 1; // return code != 0 to re-execute
        }
    }
}
