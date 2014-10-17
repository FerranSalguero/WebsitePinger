using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace WebsitePinger.Models
{
    public class PingerWebClient : WebClient
    {
        public string UserAgent { get; set; }

        public PingerWebClient(string userAgent)
        {
            this.UserAgent = userAgent;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address) as HttpWebRequest;
            request.UserAgent = UserAgent;

            return request;
        }

    }
}
