using Web.Contracts.Abstract;

namespace Web.Contracts.Models.Provider;

/// <summary>
/// Модель запроса обновления провайдера
/// </summary>
public sealed class UpdateProviderRequest : IUpdateModelRequest
{
    /// <summary>
    /// Название провайдера
    /// </summary>
    public string? Name { get; set; }
}