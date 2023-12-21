using Business.Abstract.Models;

namespace Business.Models.Provider;

/// <summary>
/// Модель обновления провайдера
/// </summary>
public sealed class UpdateProviderModel : IUpdateModel
{
    /// <summary>
    /// Номер закзаа
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// ctor.
    /// </summary>
    public UpdateProviderModel(string name)
    {
        Name = name;
    }
}