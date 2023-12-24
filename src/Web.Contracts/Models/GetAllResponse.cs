using Store.Abstract.Entity;

namespace Web.Contracts.Models;

/// <summary>
/// Модель ответа выборки
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public sealed class GetAllResponse<TEntity> where TEntity : class, IEntityWithId
{
    /// <summary>
    /// Данные
    /// </summary>
    public readonly IReadOnlyList<TEntity> Data = new List<TEntity>();

    /// <summary>
    /// Количество элементов
    /// </summary>
    public readonly int Count;
    
    /// <summary>
    /// ctor.
    /// </summary>
    public GetAllResponse(IReadOnlyList<TEntity> data, int count)
    {
        Data = data;
        Count = count;
    }
}