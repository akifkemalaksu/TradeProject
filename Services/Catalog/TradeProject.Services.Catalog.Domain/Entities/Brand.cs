using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Domain.Entities
{
    public class Brand: BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
