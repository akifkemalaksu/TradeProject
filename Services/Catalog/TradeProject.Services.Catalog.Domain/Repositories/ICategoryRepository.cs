using TradeProject.Services.Catalog.Domain.Entities;
using TradeProject.Shared.Repositories;

namespace TradeProject.Services.Catalog.Domain.Repositories
{
    public interface ICategoryRepository : IRepository<int, Category>
    {
    }
}
