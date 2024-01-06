using FluentValidation;
using Web.Contracts.Models.OrderItem;

namespace Web.Api.Validators.OrderItem;

/// <summary>
/// Валидация модели обновления элемента заказа
/// </summary>
public class UpdateOrderItemRequestValidator : AbstractValidator<UpdateOrderItemRequest>
{
    /// <summary>
    /// ctor.
    /// </summary>
    public UpdateOrderItemRequestValidator()
    {
        RuleFor(x => x.Name)
            .Cascade(CascadeMode.Stop)
            .NotNull().WithMessage(x => $"Name не может быть null")
            .NotEmpty().WithMessage(x => $"Name не может быть пустым");

        RuleFor(x => x.Unit)
            .Cascade(CascadeMode.Stop)
            .NotNull().WithMessage(x => $"Unit не может быть null")
            .NotEmpty().WithMessage(x => $"Unit не может быть пустым");

        RuleFor(x => x.OrderId)
            .Cascade(CascadeMode.Stop)
            .NotNull().WithMessage(x => "OrderId не может быть null")
            .Must(x => !x.Equals(default)).WithMessage("OrderId не может быть default");

        RuleFor(x => x.Quantity)
            .Cascade(CascadeMode.Stop)
            .NotNull().WithMessage(x => $"Quantity не может быть null")
            .Must(x =>
            {
                if (x >= 0)
                {
                    return true;
                }
                return false;
            }).WithMessage(x => $"Quantity должен быть больше нуля");
    }
}
