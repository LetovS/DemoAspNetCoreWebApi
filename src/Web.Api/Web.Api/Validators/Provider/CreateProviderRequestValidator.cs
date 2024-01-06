using FluentValidation;
using Web.Contracts.Models.Provider;

namespace Web.Api.Validators.Provider;

/// <summary>
/// Валидация модели создания провайдера
/// </summary>
public class CreateProviderRequestValidator : AbstractValidator<CreateProviderRequest>
{
    /// <summary>
    /// ctor.
    /// </summary>
    public CreateProviderRequestValidator()
    {
        RuleFor(x => x.Name)
            .Cascade(CascadeMode.Stop)
            .NotNull().WithMessage(x => $"Name не может быть null")
            .NotEmpty().WithMessage(x => $"Name не может быть пустым");
    }
}
