using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TradeProject.Shared.Entities;

namespace TradeProject.Shared.Repositories
{
    public interface IRepository<TKey, TEntity>
        where TEntity : BaseEntity<TKey>
    {
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<TEntity> Get(TKey key, bool trackChanges = true);
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> expression = null, bool trackChanges = true);
    }
}
