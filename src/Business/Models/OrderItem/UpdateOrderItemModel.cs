using Business.Abstract.Models;

namespace Business.Models.OrderItem;

/// <summary>
/// Модель обновления пункта заказа
/// </summary>
public sealed class UpdateOrderItemModel : IUpdateModel
{
    /// <summary>
    /// ctor.
    /// </summary>
    public UpdateOrderItemModel(
        string name,
        decimal quantity,
        string unit,
        Guid orderId)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
        OrderId = orderId;
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
    /// ИД поставщика
    /// </summary>
    public Guid OrderId { get; set; }
}