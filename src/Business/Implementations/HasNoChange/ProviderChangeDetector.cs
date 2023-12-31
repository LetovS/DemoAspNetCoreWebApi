﻿using Business.Abstract;
using Business.Models.Provider;
using Store.Entities;

namespace Business.Implementations.HasNoChange;

/// <summary>
/// Проверяет изменения в провайдере
/// </summary>
public sealed class ProviderChangeDetector : IChangeDetector<ProviderRecord, UpdateProviderModel>
{
    /// <inheritdoc/>
    public bool HasNoChanges(ProviderRecord entity, UpdateProviderModel model)
    {
        return model.ProviderName.Equals(entity.ProviderName);
    }
}