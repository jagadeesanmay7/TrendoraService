using Microsoft.EntityFrameworkCore;
using Trendora.Domain.Interface;
using Trendora.Domain.Models;

namespace Trendora.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {
        protected readonly TrendoraDbContext _dbContext;
        public GenericRepository(TrendoraDbContext trendoraDbContext)
        {
            _dbContext = trendoraDbContext;
        }

        public async Task<T> CreateAsync(T entity)
        {
            var addedEntity = await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().AsNoTracking().ToArrayAsync();
        }

        public async Task<T> GetByIdAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(predicate);
        }
    }
}
