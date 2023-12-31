using FluentValidation;
using Web.Contracts.Models.Provider;

namespace Web.Api.Validators.Provider;

/// <summary>
/// Валидация модели обновления провайдера
/// </summary>
public class UpdateProviderRequestValidator : AbstractValidator<UpdateProviderRequest>
{
    /// <summary>
    /// ctor.
    /// </summary>
    public UpdateProviderRequestValidator()
    {
        
    }
}