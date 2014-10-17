using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WebsitePinger.Models
{
    [Serializable()]
    [XmlRoot("sitemapindex")]
    public class SitemapIndex
    {
        [XmlArray("sitemapindex")]
        [XmlArrayItem("Car", typeof(Sitemap))]
        public Sitemap[] Sitemaps { get; set; }
    }

    [Serializable]
    public class Sitemap
    {
        public string loc { get; set; }
    }
}
