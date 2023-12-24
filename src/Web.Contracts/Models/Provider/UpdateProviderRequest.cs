namespace Web.Contracts.Models.Provider;

/// <summary>
/// Модель запроса обновления провайдера
/// </summary>
public sealed class UpdateProviderRequest
{
    /// <summary>
    /// Название провайдера
    /// </summary>
    public string? Name { get; set; }
}