using Business.Models.OrderItem;
using Store.Entities;

namespace Business.Abstract.Services;

/// <summary>
/// 
/// </summary>
public interface IOrderItemService : IBusinessService<OrderItemRecord, CreateOrderItemModel, UpdateOrderItemModel>
{
    
}