using Web.Contracts.Abstract;

namespace Web.Contracts.Models.Provider;

/// <summary>
/// Модель запроса создания провайдера
/// </summary>
public sealed class CreateProviderRequest : ICreateModelRequest
{
    /// <summary>
    /// Название провайдера
    /// </summary>
    public string? Name { get; set; }
}