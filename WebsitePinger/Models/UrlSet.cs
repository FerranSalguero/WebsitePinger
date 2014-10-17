using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WebsitePinger.Models
{
    [XmlRoot("urlset", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class UrlSet
    {
        [XmlElement("url")]
        public List<Url> Urls { get; set; }
    }

    public class Url
    {
        [XmlElement("loc")]
        public string loc { get; set; }
    }
}
