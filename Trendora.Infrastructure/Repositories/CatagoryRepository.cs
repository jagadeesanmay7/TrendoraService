using Trendora.Domain.Interface;
using Trendora.Domain.Models;

namespace Trendora.Infrastructure.Repositories
{
    public class CatagoryRepository : GenericRepository<Catagory>, ICatagoryRepository
    {
        public CatagoryRepository(TrendoraDbContext trendoraDbContext) : base(trendoraDbContext)
        {

        }
        public async Task UpdateAsync(Catagory catagory)
        {
            _dbContext.Update(catagory);
            await _dbContext.SaveChangesAsync();
        }
    }
}
