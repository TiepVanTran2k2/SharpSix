using Management.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> FindAsync(Guid id);
        Task<TEntity> InsertAsync(TEntity key);
        Task<bool> UpdateAsync(TEntity key);
        Task<bool> DeleteAsync(TEntity entity);
        Task<List<TEntity>> TolistAsync();
        Task<IQueryable<TEntity>> GetQueryableAsync();
    }
}
