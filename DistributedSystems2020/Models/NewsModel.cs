using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistributedSystems2020.Models
{
    public class NewsModel
    {
        public Payload[] value { get; set; }
    }

    public class Payload
    {
        public string name { get; set; }
        public string url { get; set; }
        public Image image { get; set; }
    }

    public class Image
    {
        public Thumbnail thumbnail { get; set; }
        
    }
    public class Thumbnail
    {
        public string contentUrl { get; set; }
        
    }
}