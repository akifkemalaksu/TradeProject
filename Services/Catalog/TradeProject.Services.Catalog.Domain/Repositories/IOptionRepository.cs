using TradeProject.Services.Catalog.Domain.Entities;
using TradeProject.Shared.Repositories;

namespace TradeProject.Services.Catalog.Domain.Repositories
{
    public interface IOptionRepository : IRepository<int, Category>
    {
    }
}
