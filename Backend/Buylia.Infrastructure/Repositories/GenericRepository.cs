using System.Linq.Expressions;
using Buylia.Application.Contracts;
using Buylia.Application.Shared;
using Buylia.Context;
using Microsoft.EntityFrameworkCore;

namespace Buylia.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly BuyliaDbContext _context;

        public GenericRepository(BuyliaDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(EntityQueryParameters queryParameters)
        {
            IQueryable<T> query = _context.Set<T>();

            if (queryParameters.Filter != null && !string.IsNullOrEmpty(queryParameters.Filter))
            {
                query = query.Where(p => p.ToString().Contains(queryParameters.Filter));
            }

            if (!string.IsNullOrEmpty(queryParameters.SortBy))
            {
                query = query.OrderBy(p => p.ToString());
            }

            if (queryParameters.Page.HasValue)
            {
                int page = queryParameters.Page.Value < 1 ? 1 : queryParameters.Page.Value;
                query = query.Skip((page - 1) * queryParameters.PageSize).Take(queryParameters.PageSize);
            }
            else
            {
                query = query.Take(queryParameters.PageSize);
            }

            return await query.ToListAsync();            
        }

        public async Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>>? filter = null,
                                                     bool noTrack = false,
                                                     params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await (noTrack ? query.AsNoTracking() : query).FirstOrDefaultAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}