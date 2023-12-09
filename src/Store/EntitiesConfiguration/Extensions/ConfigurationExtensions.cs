﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Abstract.Entity;

namespace Store.EntitiesConfiguration.Extensions;

public static class ConfigurationExtensions
{
    /// <summary>
    /// Настройка первичного ключа
    /// </summary>
    /// <remarks><Без автоинкремента счетчика идентификаторов</remarks>
    public static void ConfigureBaseEntity<TEntity>(this EntityTypeBuilder<TEntity> builder)
        where TEntity : EntityBase
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedNever();
    }
}