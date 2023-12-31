using Web.Contracts.Abstract;

namespace Web.Contracts.Models;

/// <summary>
/// Модель ответа выборки
/// </summary>
public sealed class GetAllResponse<TResponse> where TResponse : class, IResponse
{
    /// <summary>
    /// Данные
    /// </summary>
    public readonly IReadOnlyList<TResponse> Data = new List<TResponse>();

    /// <summary>
    /// Количество элементов
    /// </summary>
    public readonly int Count;
    
    /// <summary>
    /// ctor.
    /// </summary>
    public GetAllResponse(IReadOnlyList<TResponse> data, int count)
    {
        Data = data;
        Count = count;
    }
}