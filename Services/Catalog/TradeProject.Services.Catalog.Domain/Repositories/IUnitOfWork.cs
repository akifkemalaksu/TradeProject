namespace TradeProject.Services.Catalog.Domain.Repositories
{
    public interface IUnitOfWork
    {
        IBrandRepository BrandRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IOptionRepository OptionRepository { get; }
        IProductRepository ProductRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
