using Business.Abstract;
using Business.Models.Order;
using Store.Entities;

namespace Business.Implementations.HasNoChange;

/// <summary>
/// Проверяет изменения в заказе
/// </summary>
public sealed class OrderChangeDetector : IChangeDetector<OrderRecord, UpdateOrderModel>
{
    /// <inheritdoc/>
    public bool HasNoChanges(OrderRecord entity, UpdateOrderModel model)
    {
        return model.OrderNumber.Equals(entity.OrderNumber) &&
               model.ProviderId == entity.ProviderId;
    }
}