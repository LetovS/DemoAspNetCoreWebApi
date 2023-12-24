namespace Web.Contracts.Models.Provider;

/// <summary>
/// Модель запроса создания провайдера
/// </summary>
public sealed class CreateProviderRequest
{
    /// <summary>
    /// Название провайдера
    /// </summary>
    public string? Name { get; set; }
}