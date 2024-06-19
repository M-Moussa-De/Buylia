namespace Buylia.Application.Contracts;

public interface IUnitOfWork<T> where T : class , new()
{
    #region Repositories
    public IGenericRepository<T> GenericRepository { get; }
    #endregion

    #region Transaction
    Task<bool> CommitAsync(CancellationToken cancellationToken = default);
    Task RollbackAsync(CancellationToken cancellationToken = default);
    void Dispose();
    #endregion
}