using System.ComponentModel.DataAnnotations.Schema;
using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Domain.Entities
{
    [Table("Brands", Schema = "Catalog")]
    public class Brand : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
