using Trendora.Domain.Contracts;
using Trendora.Domain.Models;

namespace Trendora.Infrastructure.Repositories
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(TrendoraDbContext dbContext) : base(dbContext)
        {

        }
        public async Task UpdateAsync(Brand brand)
        {
            _dbContext.Update(brand);
            await _dbContext.SaveChangesAsync();
        }
    }
}
