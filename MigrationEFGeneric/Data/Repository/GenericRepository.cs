using DotNetEFMigration.Data.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DotNetEFMigration.Data.Repository
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        AppDbContext _dbContext;
        private DbSet<T> dbSet { get; set; }
        public GenericRepository()
        {
            _dbContext = new AppDbContext();
            this.dbSet = _dbContext.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
            var result = await dbSet.AddAsync(entity);

            await _dbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = await dbSet.FirstOrDefaultAsync(predicate);

            if (entity is null)
                return false;

            dbSet.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return (Task<IQueryable<T>>)(predicate == null ? dbSet : dbSet.Where(predicate));
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var entry = dbSet.Update(entity);

            await _dbContext.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
