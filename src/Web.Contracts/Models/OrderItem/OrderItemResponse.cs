using Web.Contracts.Abstract;

namespace Web.Contracts.Models.OrderItem;

/// <summary>
/// Модель ответа элемента заказа
/// </summary>
public sealed class OrderItemResponse : IResponse
{
    /// <summary>
    /// ctor.
    /// </summary>
    public OrderItemResponse(
        Guid id,
        string name,
        decimal quantity,
        string unit,
        Guid orderId)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Unit = unit;
        OrderId = orderId;
    }
    
    /// <summary>
    /// ИД элемента заказа
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Название товара
    /// </summary>
    public string?  Name { get; set; }
   
    /// <summary>
    /// Стоимость товара
    /// </summary>
    public decimal? Quantity { get; set; }
    
    /// <summary>
    /// Еденица измерения товара
    /// </summary>
    /// <remarks>кг, м, шт и пр. </remarks>
    public string? Unit { get; set; }

    /// <summary>
    /// ИД заказа
    /// </summary>
    public Guid? OrderId { get; set; }
}