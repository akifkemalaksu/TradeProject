using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeProject.Services.Catalog.Domain.Entities;
using TradeProject.Shared.Repositories;

namespace TradeProject.Services.Catalog.Domain.Repositories
{
    public interface IBrandRepository : IRepository<int, Brand>
    {
    }
}
