namespace Web.Contracts.Models;

/// <summary>
/// Модель результата удаления
/// </summary>
public class DeletedResourceResponse
{
    /// <summary>
    /// ИД удаленной сущности
    /// </summary>
    public Guid Id { get; set; }
}