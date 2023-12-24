using Web.Contracts.Models.Order;

namespace Web.Contracts.Models.Provider;

/// <summary>
/// Модель ответа провайдера
/// </summary>
public sealed class ProviderResponse
{
    /// <summary>
    /// ctor.
    /// </summary>
    public ProviderResponse(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
    
    /// <summary>
    /// ИД провайдера
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Название провайдера
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Заказы провайдера
    /// </summary>
    public IReadOnlyList<OrderResponse> Orders { get; set; } = new List<OrderResponse>();
}