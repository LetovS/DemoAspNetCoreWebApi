using AutoFixture;
using AutoFixture.AutoMoq;

namespace UnitTests.ChangeDetectors;

/// <summary>
/// Базовый детектор изменений
/// </summary>
public class ChangeDetectorBase
{
    /// <summary>
    /// Fixture
    /// </summary>
    protected readonly IFixture Fixture = new Fixture().Customize(new AutoMoqCustomization());
}