namespace Simply.ServiceAgent.WeatherServiceAgent.WeatherAPI.Extensions;

using Microsoft.Extensions.DependencyInjection;
using Simply.ServiceAgent.WeatherService.Agent;
using Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

/// <summary>
/// Countries service agent Extensions.
/// </summary>
public static class WeatherServiceAgentExtension
{
    /// <summary>
    /// Add countries service agent.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/> instance.</param>
    /// <returns>A given <see cref="IServiceCollection"/> instance.</returns>
    public static IServiceCollection AddWeatherServiceAgent(this IServiceCollection services)
    {
        services.AddHttpClient();
        services.AddScoped<IWeatherServiceAgent, WeatherServiceAgent>();

        return services;
    }
}
