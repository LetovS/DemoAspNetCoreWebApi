using Business.Abstract.Models;

namespace Business.Models.Provider;

/// <summary>
/// Модель создания провайдера
/// </summary>
public sealed class CreateProviderModel : ICreateModel
{
    /// <summary>
    /// Название провайдера
    /// </summary>
    public string ProviderName { get; set; }

    /// <summary>
    /// ctor.
    /// </summary>
    public CreateProviderModel(string providerName)
    {
        ProviderName = providerName;
    }
}