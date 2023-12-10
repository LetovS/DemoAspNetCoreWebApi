using Store.Abstract.Entity;

namespace Store.Entities;

/// <summary>
/// Заказ
/// </summary>
public class OrderRecord : EntityBase
{
    public OrderRecord(
        Guid id,
        string orderNumber,
        DateTime orderDate/*, Guid providerId*/) : base(id)
    {
        OrderNumber = orderNumber;
        OrderDate = orderDate;
        //ProviderId = providerId;
    }

    /// <summary>
    /// Номер заказа
    /// </summary>
    public string OrderNumber { get; set; }
    
    /// <summary>
    /// Дата заказа
    /// </summary>
    public DateTime OrderDate { get; set; }

    ///// <summary>
    ///// Все пункты заказа
    ///// </summary>
    //public virtual ICollection<OrderItemRecord> OrderItems { get; set; } = new List<OrderItemRecord>();

    /// <summary>
    /// ИД поставщика
    /// </summary>
    public Guid? ProviderId { get; set; }
    
    ///// <summary>
    ///// Поставщик
    ///// </summary>
    //public virtual ProviderRecord? Provider { get; set; }
}