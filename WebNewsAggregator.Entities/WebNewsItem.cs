using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNewsAggregator.Entities
{
    public class WebNewsItem
    {
        public string Guid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public DateTime PubDate { get; set; }

        public WebNewsSource WebNewsSource { get; set; }

        public uint WebNewsSourceId { get; set; }

    }
}
