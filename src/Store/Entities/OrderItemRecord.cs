using Store.Abstract.Entity;

namespace Store.Entities;

/// <summary>
/// Товар
/// </summary>
public class OrderItemRecord : EntityBase
{
    /// <summary>
    /// ctor.
    /// </summary>
    public OrderItemRecord(
        Guid id) : base(id)
    {
        
    }
    
    /// <summary>
    /// Название товара
    /// </summary>
    public string?  Name { get; set; }
   
    /// <summary>
    /// Стоимость товара
    /// </summary>
    public decimal Quantity { get; set; }
    
    /// <summary>
    /// Еденица измерения товара
    /// </summary>
    /// <remarks>кг, м, шт и пр. </remarks>
    public string? Unit { get; set; }

    /// <summary>
    /// ИД заказа
    /// </summary>
    public Guid OrderId { get; set; }
    
    /// <summary>
    /// Заказ
    /// </summary>
    public virtual OrderRecord? Order { get; set; }
}