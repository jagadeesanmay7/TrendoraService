using Trendora.Domain.Models;

namespace Trendora.Domain.Interface
{
    public interface ICatagoryRepository : IGenericRepository<Catagory>
    {
        Task UpdateAsync(Catagory catagory);
    }
}
