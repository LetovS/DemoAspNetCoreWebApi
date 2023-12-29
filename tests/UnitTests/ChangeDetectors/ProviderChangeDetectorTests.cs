using AutoFixture;
using Business.Abstract.Services;
using Business.Implementations.HasNoChange;
using Business.Models.Provider;
using FluentAssertions;
using Moq;
using Xunit;

namespace UnitTests.ChangeDetectors;

/// <summary>
/// Тест детектора изменений провайдера
/// </summary>
public sealed class ProviderChangeDetectorTests : ChangeDetectorBase
{
    private readonly ProviderChangeDetector _sut;
    private readonly Mock<IProviderService> _providerReadRepositoryMock;
    
    /// <summary>
    /// ctor.
    /// </summary>
    public ProviderChangeDetectorTests()
    {
        _providerReadRepositoryMock = Fixture.Freeze<Mock<IProviderService>>();
        _sut = Fixture.Create<ProviderChangeDetector>();
    }
    
    [Fact(DisplayName = "Проверка эквивалентности сущности и модели. Сущность и модель эквивалентны.")]
    internal void HasNoChanges_NoChanges_ShouldBeTrue()
    {
        // Arrange
        var entity = FactoryTestData.CreateNewProvider();

        var model = new UpdateProviderModel(entity.ProviderName ?? "test");

        _providerReadRepositoryMock.Setup(x => x.GetByIdAsync(entity.Id, It.IsAny<CancellationToken>()))
            .ReturnsAsync(entity);

        // Act
        var result = _sut.HasNoChanges(entity, model);

        // Assert
        result.Should().BeTrue();
    }

    [Fact(DisplayName = "Проверка эквивалентности сущности и модели. Сущность и модель неэквивалентны.")]
    internal void HasNoChanges_WithChanges_ShouldBeFalse()
    {
        // Arrange
        var entity = FactoryTestData.CreateNewProvider();

        var model = new UpdateProviderModel(Fixture.Create<string>());

        _providerReadRepositoryMock.Setup(x => x.GetByIdAsync(entity.Id, It.IsAny<CancellationToken>()))
            .ReturnsAsync(entity);

        // Act
        var result = _sut.HasNoChanges(entity, model);

        // Assert
        result.Should().BeFalse();
    }
}