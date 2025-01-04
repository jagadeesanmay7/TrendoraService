using System.Linq.Expressions;
using Trendora.Domain.Models;

namespace Trendora.Domain.Interface
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        Task<T> CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate);
    }
}
