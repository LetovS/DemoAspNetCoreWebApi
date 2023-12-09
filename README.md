#### Migrate
Утилита миграции БД.

Создание миграции
```shell
dotnet ef migrations add NameOfNewMigration --project src\Store.Migrations --context ResourceContext
-- NameOfMigration если не указывать, удаляет последнюю миграцию.
```
Обновление схемы БД
```shell
dotnet ef database update NameOfMigration --project src/Store.Migrations --context ResourceContext
-- NameOfMigration если не указывать, обновляет до последней миграции
```
Удаление миграции
```shell
dotnet ef migrations remove --project src/Store.Migrations --context ResourceContext
```
