using Repositories.Abstract;
using Store.Entities;

namespace Repositories.Implementations;

public class EntityFactory : IEntityFactory
{
    public ProviderRecord CreateNewProvider(
        Guid? id,
        string name) =>
            new ProviderRecord(id ?? GenerateId())
                {
                    ProviderName = name
                };

    public OrderRecord CreateNewOrder(
        Guid? id,
        string orderNumber,
        DateTime orderDate,
        Guid providerId) => 
            new OrderRecord(id ?? GenerateId())
                {
                    OrderNumber = orderNumber,
                    OrderDate = orderDate,
                    ProviderId = providerId
                };

    public OrderItemRecord CreateNewOrderItem(
        Guid? id,
        string name,
        decimal quantity,
        string unit,
        Guid orderId) =>
            new OrderItemRecord(id ?? GenerateId())
                {
                    Name = name,
                    Quantity = quantity,
                    Unit = unit,
                    OrderId = orderId
                };
    
    private static Guid GenerateId() => Guid.NewGuid();
}