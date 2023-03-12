using System.ComponentModel.DataAnnotations.Schema;
using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Domain.Entities
{

    [Table("Categories", Schema = "Catalog")]
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        [ForeignKey("ParentCategoryId")]
        public virtual Category ParentCategory { get; set; }
        public IEnumerable<Category> ChildCategories { get; set; } = Enumerable.Empty<Category>();
    }
}
