using FluentValidation;
using Web.Contracts.Models.Order;

namespace Web.Api.Validators.Order;

/// <summary>
/// Валидация создания заказа
/// </summary>
public class CreateOrderRequestValidator : AbstractValidator<CreateOrderRequest>
{
    /// <summary>
    /// ctor.
    /// </summary>
    public CreateOrderRequestValidator()
    {
        RuleFor(x => x.OrderNumber)
            .Cascade(CascadeMode.Stop)
            .NotNull().WithMessage(x => "OrderNumber не может быть null")
            .NotEmpty().WithMessage(x => "OrderNumber не может быть пустой строчкой")
            .MaximumLength(30).WithMessage(x => "Длина OrderNumber не должна превышать 30")
            .MinimumLength(5).WithMessage(x => "Длина OrderNumber должна быть больше 5");

        RuleFor(x => x.OrderDate)
            .Cascade(CascadeMode.Stop)
            .NotNull().WithMessage(x => "OrderDate не может быть null")
            .Must(x =>
            {
                if (x >= DateTime.UtcNow)
                {
                    return true;
                }
                return false;
            }).WithMessage(x => $"OrderDate не может быть раньше текущей даты {DateTime.Now.ToShortDateString()}");

        RuleFor(x => x.ProviderId)
            .Cascade(CascadeMode.Stop)
            .NotNull().WithMessage(x => "ProviderId не может быть null")
            .Must(x => !x.Equals(default)).WithMessage("ProviderId не может быть default");
    }
}