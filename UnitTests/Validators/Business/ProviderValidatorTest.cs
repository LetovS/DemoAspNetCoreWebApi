using AutoFixture;
using AutoFixture.AutoMoq;
using Business.Implementations.Validators;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Moq;
using Repositories.Abstract.Order;
using Repositories.Abstract.Provider;
using Repositories.Implementations.Order;
using Repositories.Implementations.Provider;
using UnitTests.ChangeDetectors;
using Xunit;

namespace UnitTests.Validators.Business;

/// <summary>
/// Валидатор провайдера
/// </summary>
public class ProviderValidatorTest : BusinessValidatorBase
{
    private readonly IProviderReadRepository _providerReadRepositoryMock;
    private readonly IOrderReadRepository _orderReadRepositoryMock;
    private readonly ProviderValidator _sut;

    /// <summary>
    /// ctor.
    /// </summary>
    public ProviderValidatorTest(
    )
    {
        _providerReadRepositoryMock = Fixture.Create<IProviderReadRepository>();
        _orderReadRepositoryMock = Fixture.Create<OrderReadRepository>();
        _sut = new ProviderValidator(_providerReadRepositoryMock, _orderReadRepositoryMock);
    }
    
    [Fact(DisplayName = "Проверка возможности сохранения. Сохранить возможно.")]
    public async Task ValidateSave_ShouldBeTrue()
    {
        // Arrange
        var newEntity = FactoryTestData.CreateNewProvider();

        // Act
        Func<Task> f = async () => await _sut.ValidateSave(newEntity, CancellationToken.None);

        // Assert
        var exception = await f.Should().ThrowAsync<ArgumentException>();
        exception.BeNull();
        /*.BeEquivalentTo(new
        {
            Message = "Сохранить нельзя"
        });*/
    }
    
    //[Fact(DisplayName = "Проверка возможности сохранения. Сохранить невозможно.")]
    //public async Task ValidateSave_ShouldBeFalse()
    //{
    //    // Arrange
    //    var entity = FactoryTestData.CreateNewProvider();
        
    //    // Act
    //    var result = await _sut.ValidateSave(entity, CancellationToken.None);

    //    // Assert
    //    result.Should().BeTrue();
    //}
}