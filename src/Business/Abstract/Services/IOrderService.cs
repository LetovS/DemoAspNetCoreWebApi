using Business.Models;
using Business.Models.Order;
using Store.Entities;

namespace Business.Abstract.Services;

/// <summary>
/// 
/// </summary>
public interface IOrderService : IBusinessService
{
    
    /// <summary>
    /// Получить по ИД
    /// </summary>
    public Task<OrderRecord?> GetByIdAsync(Guid id, CancellationToken ct = default);

    /// <summary>
    /// Получить все сущности
    /// </summary>
    public Task<ResourceGetModel<OrderRecord>> GetAll(int offset = 0, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// Создать сущность
    /// </summary>
    public Task<Guid> CreateAsync(Guid id, CreateOrderModel model, CancellationToken ct = default);

    /// <summary>
    /// Обновить модель
    /// </summary>
    public Task<bool> UpdateAsync(Guid id, UpdateOrderModel model, CancellationToken ct = default);

    /// <summary>
    /// Удалить по ИД
    /// </summary>
    public Task<bool> DeleteAsync(Guid id, CancellationToken ct = default);
    
    /// <summary>
    /// Получить все заказы по номеру поставщика услуг
    /// </summary>
    Task<IReadOnlyList<OrderRecord>> GetAllByProviderId(Guid providerId, CancellationToken ct = default);

    /// <summary>
    /// Получить заказ по номеру
    /// </summary>
    Task<OrderRecord?> GetByNumber(string number, CancellationToken ct = default);
}