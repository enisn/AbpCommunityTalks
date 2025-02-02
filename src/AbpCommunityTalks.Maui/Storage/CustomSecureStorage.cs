﻿using Volo.Abp.DependencyInjection;

namespace AbpCommunityTalks.Maui.Storage;

[Volo.Abp.DependencyInjection.Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ISecureStorage))]
public class CustomSecureStorage : ISecureStorage, ITransientDependency
{
    public Task<string> GetAsync(string key)
    {
#if DEBUG
        return Task.FromResult(Preferences.Get(key, string.Empty));
#else
        return SecureStorage.GetAsync(key);
#endif
    }

    public bool Remove(string key)
    {
#if DEBUG
        Preferences.Remove(key, string.Empty);
        return true;
#else
        return SecureStorage.Remove(key);
#endif
    }

    public void RemoveAll()
    {
#if DEBUG
        Preferences.Clear();
#else
        return SecureStorage.RemoveAll();
#endif
    }

    public Task SetAsync(string key, string value)
    {
#if DEBUG
        Preferences.Set(key, value);
        return Task.CompletedTask;
#else
        return SecureStorage.SetAsync(key);
#endif
    }
}