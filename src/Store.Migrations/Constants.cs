namespace Store.Migrations;

internal static class Constants
{
    /// <summary>
    /// Строка подключения
    /// </summary>
    internal const string ConnectionString =
        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DemoWebApi.Resource;";

    /// <summary>
    /// Название сборки миграций
    /// </summary>
    internal const string MigrationsAssemblyName = "src/Store.Migrations";
    
    /// <summary>
    /// Имя таблицы в БД истории миграций
    /// </summary>
    internal const string MigrationsHistoryTableName = "_EFMigrationsHostory";
    
}