using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeProject.Services.Catalog.Domain.Entities;
using TradeProject.Shared.Entities;

namespace TradeProject.Services.Catalog.Infrastructure.EntityFramework
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OptionItem> OptionItems { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddEventListener();
            UpdateEventListener();
            DeleteEventListener();

            return base.SaveChangesAsync(cancellationToken);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            AddEventListener();
            UpdateEventListener();
            DeleteEventListener();

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void AddEventListener()
        {
            var added = ChangeTracker.Entries<BaseEntity<int>>().Where(x => x.State == EntityState.Added).Select(x => x.Entity).ToList();
            if (!added.Any()) return;

            Parallel.ForEach(added, entity =>
            {
                entity.CreatedTime = DateTime.UtcNow;
                entity.Deleted = false;
            });
        }

        private void UpdateEventListener()
        {
            var updated = ChangeTracker.Entries<BaseEntity<int>>().Where(x => x.State == EntityState.Added).Select(x => x.Entity).ToList();
            if (!updated.Any()) return;

            Parallel.ForEach(updated, entity =>
            {
                entity.ModifiedTime = DateTime.UtcNow;
            });
        }

        private void DeleteEventListener()
        {
            var deleted = ChangeTracker.Entries<BaseEntity<int>>().Where(x => x.State == EntityState.Added).ToList();
            if (!deleted.Any()) return;

            Parallel.ForEach(deleted, entity =>
            {
                entity.State = EntityState.Modified;
                entity.Entity.ModifiedTime = DateTime.UtcNow;
                entity.Entity.Deleted = true;
            });
        }
    }
}
