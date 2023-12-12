namespace Store.Abstract.Context;

public interface IDbUnitOfWork
{
    /// <summary>
    /// Сохранить изменения в БД
    /// </summary>
    Task<int> SaveChangesAsync(CancellationToken ct = default);
}