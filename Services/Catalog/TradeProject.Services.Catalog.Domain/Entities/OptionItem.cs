using System.ComponentModel.DataAnnotations.Schema;
using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Domain.Entities
{
    [Table("OptionItems", Schema = "Catalog")]
    public class OptionItem : BaseEntity<int>
    {
        public string Name { get; set; }
        public int OptionId { get; set; }
        [ForeignKey("OptionId")]
        public virtual Option Option { get; set; }
    }
}
