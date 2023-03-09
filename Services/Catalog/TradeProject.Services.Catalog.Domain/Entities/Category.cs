using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
        public Category ParentCategory { get; set; }
        public IEnumerable<Category> ChildCategories { get; set; } = Enumerable.Empty<Category>();
    }
}
