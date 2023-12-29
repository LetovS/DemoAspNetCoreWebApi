namespace Web.Contracts.Models;

/// <summary>
/// Фильтр пагинации
/// </summary>
public class PaginationFilter
{
    /// <summary>
    /// Количество элементов которое нужно пропустить
    /// </summary>
    public int Offset { get; set; }

    /// <summary>
    /// Количество элементов которое необходимо получить
    /// </summary>
    public int Limit { get; set; }
}