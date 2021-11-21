using WebNewsAggregator.Entities;
using WebNewsAggregator.Services.Interfaces.Repositories;

namespace WebNewsAggregator.Repositories
{
    public class WebNewsSourceRepo : IWebNewsSourceRepo
    {
        public void Create(WebNewsSource webNewsSource)
        {
            using (var context = new WebNewsAggregatorContext())
            {
                context.WebNewsSources.Add(webNewsSource);
                context.SaveChanges();
            }
        }

        public WebNewsSource GetByAddress(string address)
        {
            using (var context = new WebNewsAggregatorContext())
            {
                return context.WebNewsSources.FirstOrDefault(x => x.Address == address);
            }
        }
    }
}