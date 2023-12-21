using Business.Abstract;
using Business.Models.OrderItem;
using Store.Entities;

namespace Business.Implementations.HasNoChange;

/// <summary>
/// Проверяет изменения в товаре
/// </summary>
public sealed class OrderItemHasNoChange : IChangeDetector<OrderItemRecord, UpdateOrderItemModel>
{
    /// <inheritdoc/>
    public bool HasNoChanges(OrderItemRecord entity, UpdateOrderItemModel model)
    {
        return model.Name.Equals(entity.Name) &&
               model.Quantity == entity.Quantity &&
               model.Unit == entity.Unit &&
               model.OrderId == entity.OrderId;
    }
}