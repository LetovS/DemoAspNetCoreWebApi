using FluentValidation;
using Web.Contracts.Models.Order;

namespace Web.Api.Validators.Order;

/// <summary>
/// Валидация обновления заказа
/// </summary>
public class UpdateOrderRequestValidator : AbstractValidator<UpdateOrderRequest>
{
    /// <summary>
    /// ctor.
    /// </summary>
    public UpdateOrderRequestValidator()
    {
        
    }
}