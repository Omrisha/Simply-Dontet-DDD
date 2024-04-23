namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

/// <summary>
/// Get weather for city input.
/// </summary>
public class GetWeatherForCityInput
{
    /// <summary>
    /// Gets or sets city name.
    /// </summary>
    public string CityName { get; set; }
}