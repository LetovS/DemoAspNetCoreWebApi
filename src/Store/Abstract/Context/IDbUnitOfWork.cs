namespace Store.Abstract.Context;

/// <summary>
/// Модуль
/// </summary>
public interface IDbUnitOfWork
{
    /// <summary>
    /// Сохранить изменения в БД
    /// </summary>
    Task<int> SaveChangesAsync(CancellationToken ct = default);
}