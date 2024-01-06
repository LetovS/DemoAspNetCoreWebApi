using System.ComponentModel.DataAnnotations;

namespace Web.Api.Validators;

/// <summary>
/// Значение типа <see cref="Guid"/> не должно быть по умолчанию
/// </summary>
public class NotDefaultGuidAttribute : ValidationAttribute
{
    private const string DefaultErrorMessage = "У поля {0} не должно быть значение по умолчанию";

    /// <inheritdoc />
    public NotDefaultGuidAttribute() : base(DefaultErrorMessage) { }

    /// <inheritdoc />
    public override bool IsValid(object? value)
    {
        if (value is not Guid guidValue)
        {
            throw new ArgumentException("Поле не является Guid'ом");
        }

        return guidValue != Guid.Empty;
    }
}