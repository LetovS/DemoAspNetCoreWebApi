using Store.Abstract;

namespace Store.Entities;

/// <summary>
/// Заказ
/// </summary>
public class OrderRecord : EntityBase
{
    public OrderRecord(Guid id) : base(id)
    {
    }

    public string OrderNumber { get; set; }
    
    /// <summary>
    /// Дата заказа
    /// </summary>
    public DateOnly OrderDate { get; set; }
    
    /// <summary>
    /// Все пункты заказа
    /// </summary>
    public virtual ICollection<OrderItemRecord> OrderItems { get; set; }
    
    /// <summary>
    /// Поставщик
    /// </summary>
    public virtual ProviderRecord Provider { get; set; }
}