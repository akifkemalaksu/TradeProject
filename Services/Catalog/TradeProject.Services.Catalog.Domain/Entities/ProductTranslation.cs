using System.ComponentModel.DataAnnotations.Schema;
using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Domain.Entities
{
    [Table("ProductTranslations", Schema = "Catalog")]
    public class ProductTranslation : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public int LanguageId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
