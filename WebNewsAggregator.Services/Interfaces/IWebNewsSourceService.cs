using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNewsAggregator.Services.Interfaces
{
    public interface IWebNewsSourceService
    {
        void CreateWebNewsSource(Entities.WebNewsSource webNewsSource);
    }
}
