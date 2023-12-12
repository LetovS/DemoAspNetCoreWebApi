namespace Store.ConfigurationOptions;

/// <summary>
/// Настройки базы данных
/// </summary>
public class DatabaseOptions
{
    /// <summary>
    /// Адрес строки подключения к БД
    /// </summary>
    public string ConnectionString { get; set; }

    /// <summary>
    /// Название сборки миграций
    /// </summary>
    public string MigrationsAssemblyName { get; set; }

    /// <summary>
    /// Название таблицы миграций в БД
    /// </summary>
    public string MigrationsHistoryTableName { get; set; }
}