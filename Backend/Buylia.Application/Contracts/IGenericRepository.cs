using Buylia.Application.Shared;
using System.Linq.Expressions;

namespace Buylia.Application.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync(EntityQueryParameters queryParameters);

        Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>>? filter = null,
                                        bool noTrack = false,
                                        params Expression<Func<T, object>>[] includeProperties);

        Task<T?> GetByIdAsync(int id);

        Task CreateAsync(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}