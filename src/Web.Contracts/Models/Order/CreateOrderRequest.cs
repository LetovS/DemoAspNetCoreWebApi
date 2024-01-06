using Web.Contracts.Abstract;

namespace Web.Contracts.Models.Order;

/// <summary>
/// Модель запроса создания заказа
/// </summary>
public sealed class CreateOrderRequest : ICreateModelRequest
{
    /// <summary>
    /// Номер заказа
    /// </summary>
    public string? OrderNumber { get; set; }
    
    /// <summary>
    /// Дата заказа
    /// </summary>
    public DateTime? OrderDate { get; set; }

    /// <summary>
    /// ИД поставщика
    /// </summary>
    public Guid? ProviderId { get; set; }
}