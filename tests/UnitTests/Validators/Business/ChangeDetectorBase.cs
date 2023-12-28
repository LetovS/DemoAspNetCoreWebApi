using AutoFixture;
using AutoFixture.AutoMoq;

namespace UnitTests.Validators;

/// <summary>
/// Базовый детектор изменений
/// </summary>
public class BusinessValidatorBase
{
    /// <summary>
    /// Fixture
    /// </summary>
    protected readonly IFixture Fixture = new Fixture().Customize(new AutoMoqCustomization());
}