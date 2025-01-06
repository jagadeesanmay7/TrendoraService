using Trendora.Domain.Interface;
using Trendora.Domain.Models;

namespace Trendora.Domain.Contracts
{
    public interface IBrandRepository : IGenericRepository<Brand>
    {
        Task UpdateAsync(Brand brand);
    }
}
