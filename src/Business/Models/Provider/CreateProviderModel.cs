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
    public string Name { get; set; }

    /// <summary>
    /// ctor.
    /// </summary>
    public CreateProviderModel(string name)
    {
        Name = name;
    }
}