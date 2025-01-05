using Trendora.Domain.Models;

namespace Trendora.Domain.Interface
{
    public interface ICategoryRepository : IGenericRepository<Catagory>
    {
        Task UpdateAsync(Catagory catagory);
    }
}
