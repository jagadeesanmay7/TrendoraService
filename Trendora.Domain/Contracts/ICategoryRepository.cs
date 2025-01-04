using Trendora.Domain.Models;

namespace Trendora.Domain.Interface
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task UpdateAsync(Category category);
    }
}
