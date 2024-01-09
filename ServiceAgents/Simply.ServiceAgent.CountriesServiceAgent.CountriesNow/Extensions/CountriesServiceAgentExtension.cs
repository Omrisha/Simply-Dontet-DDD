namespace Simply.ServiceAgent.CountriesServiceAgent.CountriesNow.Extensions;

using Microsoft.Extensions.DependencyInjection;
using Simply.ServiceAgent.CountriesServiceAgent.Abstractions;

/// <summary>
/// Countries service agent Extensions.
/// </summary>
public static class CountriesServiceAgentExtension
{
    /// <summary>
    /// Add countries service agent.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/> instance.</param>
    /// <returns>A given <see cref="IServiceCollection"/> instance.</returns>
    public static IServiceCollection AddCountriesServiceAgent(this IServiceCollection services)
    {
        services.AddHttpClient();
        services.AddScoped<ICountriesSeviceAgent, CountriesServiceAgent>();

        return services;
    }
}
