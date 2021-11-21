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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=postgres;Username=postgres;Password=password");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
