using CINEMATRIX.Data.Domain;
using CINEMATRIX.Data.EF.SQL;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CINEMATRIX.Data.Services.Abstraction
{
    public interface IBaseService<TEntity> where TEntity : KeyedEntityBase
    {
        Task<TEntity> GetByIdAsync(long? id, CancellationToken cancellationToken = default);
        Task<IReadOnlyCollection<TEntity>> GetAsync(CancellationToken cancellationToken = default);
        Task<TEntity> InsertAsync(TEntity newEntity, CancellationToken cancellationToken = default);
        Task<TEntity> UpdateAsync(TEntity newEntity, CancellationToken cancellationToken = default);
        Task DeleteAsync(long? id, CancellationToken cancellationToken = default);
    }

    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : KeyedEntityBase
    {
        protected readonly ApplicationDbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();

        }

        public virtual async Task<TEntity> GetByIdAsync(long? id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(new object[] { id }, cancellationToken);
        }

        public virtual async Task<IReadOnlyCollection<TEntity>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await _dbSet.AsNoTracking().ToListAsync(cancellationToken);
        }

        public virtual async Task<TEntity> InsertAsync(TEntity newEntity, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(newEntity);
            await _dbContext.SaveChangesAsync();

            return newEntity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity newEntity, CancellationToken cancellationToken = default)
        {
            if (_dbContext.Entry(newEntity).State == EntityState.Detached)
            {
                _dbSet.Attach(newEntity);
            }

            _dbContext.ChangeTracker.DetectChanges();
            await _dbContext.SaveChangesAsync();

            return newEntity;
        }

        public virtual async Task DeleteAsync(long? id, CancellationToken cancellationToken = default)
        {
            var entity = await GetByIdAsync(id, cancellationToken);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
