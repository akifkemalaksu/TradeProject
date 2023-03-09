using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Domain.Entities
{
    public class OptionItem : BaseEntity<int>
    {
        public string Name { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
    }
}
