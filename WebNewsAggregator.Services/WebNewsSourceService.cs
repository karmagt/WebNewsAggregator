using WebNewsAggregator.Entities;
using WebNewsAggregator.Services.Interfaces;
using WebNewsAggregator.Services.Interfaces.Repositories;

namespace WebNewsAggregator.Services
{
    public class WebNewsSourceService : IWebNewsSourceService
    {
        private const string SourceExistsInSystem = "Данный источник новостей уже добавлен в систему";

        private IWebNewsSourceRepo WebNewsRepo;

        public WebNewsSourceService(IWebNewsSourceRepo webNewsSourceRepo)
        {
            this.WebNewsRepo = webNewsSourceRepo;
        }
        public void CreateWebNewsSource(WebNewsSource webNewsSource)
        {
            if (WebNewsRepo.GetByAddress(webNewsSource.Address) != null)
            {
                throw new Exception(SourceExistsInSystem);
            }
            WebNewsRepo.Create(webNewsSource);
        }
    }
}