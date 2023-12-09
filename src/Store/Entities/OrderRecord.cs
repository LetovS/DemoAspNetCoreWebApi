using Store.Abstract.Entity;

namespace Store.Entities;

/// <summary>
/// Заказ
/// </summary>
public class OrderRecord : EntityBase
{
    public OrderRecord(Guid id, string orderNumber, DateOnly orderDate) : base(id)
    {
        OrderNumber = orderNumber;
        OrderDate = orderDate;
    }

    /// <summary>
    /// Номер заказа
    /// </summary>
    public string OrderNumber { get; set; }
    
    /// <summary>
    /// Дата заказа
    /// </summary>
    public DateOnly OrderDate { get; set; }

    /// <summary>
    /// Все пункты заказа
    /// </summary>
    public virtual ICollection<OrderItemRecord> OrderItems { get; set; } = new List<OrderItemRecord>();
    
    /// <summary>
    /// Поставщик
    /// </summary>
    public virtual ProviderRecord? Provider { get; set; }
}