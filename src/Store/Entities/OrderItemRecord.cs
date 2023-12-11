using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Store.Abstract.Entity;

namespace Store.Entities;

/// <summary>
/// Товар
/// </summary>
public class OrderItemRecord : EntityBase
{
    public OrderItemRecord(
        Guid id,
        string name,
        decimal quantity,
        string unit/*, Guid orderId*/) : base(id)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
        //OrderId = orderId;
    }
    
    /// <summary>
    /// Название товара
    /// </summary>
    public string  Name { get; set; }
   
    /// <summary>
    /// Стоимость товара
    /// </summary>
    public decimal Quantity { get; set; }
    
    /// <summary>
    /// Еденица измерения товара
    /// </summary>
    /// <remarks>кг, м, шт и пр. </remarks>
    public string Unit { get; set; }
    
    /// <summary>
    /// ИД заказа
    /// </summary>
    //public Guid? OrderId { get; set; }
}