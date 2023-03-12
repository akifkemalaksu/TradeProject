using System.ComponentModel.DataAnnotations.Schema;
using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Domain.Entities
{
    [Table("Options", Schema = "Catalog")]
    public class Option : BaseEntity<int>
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public IEnumerable<OptionItem> Items { get; set; } = Enumerable.Empty<OptionItem>();
    }
}
