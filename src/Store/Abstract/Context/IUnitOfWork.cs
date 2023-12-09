namespace Store.Abstract.Context;

public interface IUnitOfWork
{
    /// <summary>
    /// Сохранить изменения в БД
    /// </summary>
    Task<int> SaveChangesAsync(CancellationToken ct = default);
}