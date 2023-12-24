namespace Web.Contracts.Models.OrderItem;

/// <summary>
/// Модель запроса обновления пункта заказа
/// </summary>
public sealed class UpdateOrderItemRequest
{
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