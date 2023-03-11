using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Domain.Entities
{
    public class Option : BaseEntity<int>
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public IEnumerable<OptionItem> Items { get; set; } = Enumerable.Empty<OptionItem>();
    }
}
