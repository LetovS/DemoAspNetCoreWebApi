using Store.Abstract.Entity;

namespace Business.Models;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public sealed class ResourceGetModel<TEntity> where TEntity : class, IEntityWithId
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
    public ResourceGetModel(IReadOnlyList<TEntity> data, int count)
    {
        Data = data;
        Count = count;
    }
    
}