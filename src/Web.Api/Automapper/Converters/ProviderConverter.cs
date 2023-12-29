using AutoMapper;
using Store.Entities;
using Web.Contracts.Models.Provider;

namespace Web.Api.Automapper.Converters;

/// <summary>
/// Конвертер из <see cref="ProviderRecord"/> в <see cref="ProviderResponse"/>
/// </summary>
public class ProviderConverter : ITypeConverter<List<ProviderRecord>, IEnumerable<ProviderResponse>>
{
    /// <summary>
    /// ctor.
    /// </summary>
    public IEnumerable<ProviderResponse> Convert(List<ProviderRecord> source, IEnumerable<ProviderResponse> destination, ResolutionContext context)
    {
        foreach (var item in source)
        {
            yield return new ProviderResponse(item.Id, item.ProviderName);
        }
        
    }
}