using Microsoft.Extensions.DependencyInjection;

namespace AudioTranscriber.Shared;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSharedServices(this IServiceCollection services)
    {
        // Register application services here
        // Example: services.AddScoped<IMyService, MyService>();

        return services;
    }

}