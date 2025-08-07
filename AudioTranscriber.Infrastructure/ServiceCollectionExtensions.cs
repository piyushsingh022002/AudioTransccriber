using Microsoft.Extensions.DependencyInjection;

namespace AudioTranscriber.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // Register application services here
        // Example: services.AddScoped<IMyService, MyService>();

        return services;
    }

}
