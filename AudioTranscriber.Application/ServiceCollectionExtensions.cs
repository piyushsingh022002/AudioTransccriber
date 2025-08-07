using Microsoft.Extensions.DependencyInjection;
namespace AudioTranscriber.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Register application services here
        // Example: services.AddScoped<IMyService, MyService>();

        return services;
    }

}
