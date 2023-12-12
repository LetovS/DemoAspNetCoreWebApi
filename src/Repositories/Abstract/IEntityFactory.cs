using Store.Entities;

namespace Repositories.Abstract;

public interface IEntityFactory
{
    /// <summary>
    /// Создает нового поставщика услуг
    /// </summary>
    ProviderRecord CreateNewProvider(Guid? id, string name);
    
    /// <summary>
    /// Создает новый заказ
    /// </summary>
    OrderRecord CreateNewOrder(
        Guid? id,
        string orderNumber,
        DateTime orderDate,
        Guid providerId);
    
    /// <summary>
    /// Создает товар заказа
    /// </summary>
    OrderItemRecord CreateNewOrderItem(
        Guid? id,
        string name,
        decimal quantity,
        string unit,
        Guid orderId);
}