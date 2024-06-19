using Buylia.Application.Contracts;
using Buylia.Context;
using Buylia.Infrastructure.Repositories;

namespace Buylia.Infrastructure;

public class UnitOfWork<T> : IUnitOfWork<T> where T : class, new()
{
    private readonly BuyliaDbContext _context;
    private IGenericRepository<T>? _genericRepository;
    private bool _disposed = false;


    public UnitOfWork(BuyliaDbContext context)
    {
        _context = context;
    }

    public IGenericRepository<T> GenericRepository
    {
        get
        {
            _genericRepository ??= new GenericRepository<T>(_context);
            return _genericRepository;
        }
    }

    #region Transaction
    public virtual async Task<bool> CommitAsync(CancellationToken cancellationToken = default)
    {
        bool result = false;
        using (var transaction = await _context.Database.BeginTransactionAsync(cancellationToken))
        {
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
                result = true;
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
        }

        return result;
    }

    public virtual Task RollbackAsync(CancellationToken cancellationToken = default)
    {
        _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());

        return Task.CompletedTask;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        _disposed = true;
    }
    #endregion
}
