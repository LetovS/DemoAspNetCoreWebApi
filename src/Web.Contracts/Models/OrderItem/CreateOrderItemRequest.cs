using Web.Contracts.Abstract;

namespace Web.Contracts.Models.OrderItem;

/// <summary>
/// Модель запроса создания пункта заказа
/// </summary>
public sealed class CreateOrderItemRequest : ICreateModelRequest
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