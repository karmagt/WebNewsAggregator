using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNewsAggregator.Entities;

namespace WebNewsAggregator.Repositories
{
    internal class WebNewsAggregatorContext : DbContext
    {
        public DbSet<WebNewsSource> WebNewsSources { get; set; }
        public DbSet<WebNewsItem> WebNewsItems { get; set; }

        public WebNewsAggregatorContext()
        {
            Database.EnsureCreated();
        }
    }
}
