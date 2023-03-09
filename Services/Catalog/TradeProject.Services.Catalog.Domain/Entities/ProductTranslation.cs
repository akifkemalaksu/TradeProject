using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Domain.Entities
{
    public class ProductTranslation : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public int LanguageId { get; set; }
    }
}
