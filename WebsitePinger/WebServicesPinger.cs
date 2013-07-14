using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using WebsitePinger.Models;

namespace WebsitePinger
{
    public class WebServicesPinger
    {
        public WebServicesPinger()
        {
            var services = new List<WebServiceConfig> {
                new WebServiceConfig { Url = "http://wmservice.apphb.com/TestService.svc",
                    SOAPAction = "\"http://tempuri.org/ITestService/Bootstrap\"",
                    Data = @"<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' xmlns:tem='http://tempuri.org/' xmlns:wm='http://schemas.datacontract.org/2004/07/WM.WCF.Service.Services'>
   <soapenv:Header/>
   <soapenv:Body>
      <tem:Bootstrap>
         <tem:thanks>
            <wm:Key>Sups62</wm:Key>
         </tem:thanks>
      </tem:Bootstrap>
   </soapenv:Body>
</soapenv:Envelope>"}
            };

            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type", "text/xml;charset=utf-8");
                foreach (var item in services)
                {
                    try
                    {
                        client.Headers.Add("SOAPAction", item.SOAPAction);
                        client.UploadString(item.Url, item.Data);
                        // TODO: log response
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
