using Business.Abstract.Models;
using Store.Abstract.Entity;

namespace Business.Abstract;

/// <summary>
/// Детектор изменений в модели
/// </summary>
/// <typeparam name="TEntity">Объект из БД</typeparam>
/// <typeparam name="TUpdateModel">Модель для обновления</typeparam>
public interface IChangeDetector<in TEntity, in TUpdateModel>
    where TEntity : class, IEntity
    where TUpdateModel : class, IUpdateModel
{
    /// <summary>
    /// Вычислить, эквивалентна модель <see cref="TUpdateModel"/> сущности <see cref="TEntity"/>
    /// </summary>
    bool HasNoChanges(TEntity entity, TUpdateModel model);
}