using Business.Abstract.Models;

namespace Business.Models.Order;

/// <summary>
/// Модель создания заказа
/// </summary>
public sealed class CreateOrderModel : ICreateModel
{
    /// <summary>
    /// ctor.
    /// </summary>
    public CreateOrderModel(
        string orderNumber,
        DateTime orderDate,
        Guid providerId)
    {
        OrderNumber = orderNumber;
        OrderDate = orderDate;
        ProviderId = providerId;
    }
    
    /// <summary>
    /// Номер заказа
    /// </summary>
    public string OrderNumber { get; set; }
    
    /// <summary>
    /// Дата заказа
    /// </summary>
    public DateTime OrderDate { get; set; }

    /// <summary>
    /// ИД поставщика
    /// </summary>
    public Guid ProviderId { get; set; }
}