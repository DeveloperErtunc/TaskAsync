namespace TaskAsync.Service.Configuration;

public static class AddDependency
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddSingleton<IReadService, ReadService>();
        services.AddSingleton<ISnowService, SnowService>();
        services.AddSingleton<ITaskService, TaskService>();
        
        return services;
    }
    public static IServiceCollection HttpClientAdd(this IServiceCollection services)
    {
        services.AddHttpClient(StringConstants.CountriesSnow, c =>
        {
            c.BaseAddress = new Uri(StringConstants.CountriesSnowBaseAPI);
        });
        return services;
    }
}
