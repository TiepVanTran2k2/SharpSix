using Management.Domain.Entity;
using Management.Domain.Repository;
using Management.EntityFrameworkCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.EntityFrameworkCore.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        public DbSet<TEntity> _dbSet;
        public DbContextApp _dbContext;
        public RepositoryBase(DbContextApp dbContextApp)
        {
            _dbContext = dbContextApp;
        }
        public async Task<bool> DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<TEntity> FindAsync(Guid id)
        {
            var result = await _dbSet.FindAsync(id);
            return result;
        }

        public async Task<IQueryable<TEntity>> GetQueryableAsync()
        {
            return await Task.FromResult(_dbSet.AsQueryable());
        }

        public async Task<TEntity> InsertAsync(TEntity key)
        {
            await _dbSet.AddAsync(key);
            await _dbContext.SaveChangesAsync();
            return key;
        }

        public async Task<List<TEntity>> TolistAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<bool> UpdateAsync(TEntity key)
        {
            _dbSet.Update(key);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
