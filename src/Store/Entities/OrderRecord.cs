using Store.Abstract.Entity;

namespace Store.Entities;

/// <summary>
/// Заказ
/// </summary>
public class OrderRecord : EntityBase
{
    /// <summary>
    /// ctor.
    /// </summary>
    public OrderRecord(
        Guid id) : base(id)
    {
    }

    /// <summary>
    /// Номер заказа
    /// </summary>
    public string? OrderNumber { get; set; }
    
    /// <summary>
    /// Дата заказа
    /// </summary>
    public DateTime OrderDate { get; set; }

    /// <summary>
    /// ИД поставщика
    /// </summary>
    public Guid ProviderId { get; set; }
    
    /// <summary>
    /// Провайдер
    /// </summary>
    public virtual ProviderRecord? Provider { get; set; }

    /// <summary>
    /// Номенклатура заказа
    /// </summary>
    public virtual List<OrderItemRecord> OrderItems { get; set; } = new List<OrderItemRecord>();
}