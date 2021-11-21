using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNewsAggregator.Entities;

namespace WebNewsAggregator.Services.Interfaces.Repositories
{
    public interface IWebNewsSourceRepo
    {
        void Create(Entities.WebNewsSource webNewsSource);
        WebNewsSource GetByAddress(string address);
    }
}
