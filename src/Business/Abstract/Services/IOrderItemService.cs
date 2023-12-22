using Business.Models;
using Business.Models.OrderItem;
using Store.Entities;

namespace Business.Abstract.Services;

/// <summary>
/// 
/// </summary>
public interface IOrderItemService : IBusinessService
{
    /// <summary>
    /// Получить по ИД
    /// </summary>
    public Task<OrderItemRecord?> GetByIdAsync(Guid id, CancellationToken ct = default);

    /// <summary>
    /// Получить все сущности
    /// </summary>
    public Task<ResourceGetModel<OrderItemRecord>> GetAll(int offset = 0, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// Создать сущность
    /// </summary>
    public Task<Guid> CreateAsync(Guid id, CreateOrderItemModel model, CancellationToken ct = default);

    /// <summary>
    /// Обновить модель
    /// </summary>
    public Task<bool> UpdateAsync(Guid id, UpdateOrderItemModel model, CancellationToken ct = default);

    /// <summary>
    /// Удалить по ИД
    /// </summary>
    public Task<bool> DeleteAsync(Guid id, CancellationToken ct = default);
}