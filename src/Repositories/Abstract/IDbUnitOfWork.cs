namespace Repositories.Abstract;

public interface IDbUnitOfWork : IDbRepository
{
    Task SaveChangeAsync(CancellationToken ct = default);
}