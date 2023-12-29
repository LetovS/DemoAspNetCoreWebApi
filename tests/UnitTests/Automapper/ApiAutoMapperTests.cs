using AutoMapper;
using Business.Automapper;
using Xunit;

namespace UnitTests.Automapper;

/// <summary>
/// Тест коинсистенции профайлов
/// </summary>
public class ApiAutoMapperTests
{
    private readonly IMapper mapper;
    
    /// <summary>
    /// ctor.
    /// </summary>
    public ApiAutoMapperTests()
    {
        mapper = new MapperConfiguration(p =>
        {
            var assembly = new[] { typeof(BusinessProfile).Assembly };

            var profiles = assembly.Select(x => x.GetTypes()
                    .Where(x => typeof(Profile).IsAssignableFrom(x)))
                .SelectMany(x => x);

            foreach (var profile in profiles)
            {
                p.AddProfile(Activator.CreateInstance(profile) as Profile);
            }
        }).CreateMapper();
    }
    
    [Fact(DisplayName = "Проверка валидности маппинга")]
    internal void ShouldBeValid()
    {
        mapper.ConfigurationProvider.AssertConfigurationIsValid();
    }
}