using Trendora.Domain.Interface;
using Trendora.Domain.Models;

namespace Trendora.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(TrendoraDbContext trendoraDbContext) : base(trendoraDbContext)
        {

        }
        public async Task UpdateAsync(Category category)
        {
            _dbContext.Update(category);
            await _dbContext.SaveChangesAsync();
        }
    }
}
