using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WebsitePinger.Models
{
    [XmlRoot("sitemapindex", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class SitemapIndex
    {
        [XmlAttribute("xmlns")]
        public string Xmlns { get; set; }

        [XmlElement("sitemap")]
        public List<Sitemap> Sitemaps { get; set; }
    }

    public class Sitemap
    {
        [XmlElement("loc")]
        public string loc { get; set; }
    }
}
