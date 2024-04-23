namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Get weather for city output.
/// </summary>
public class GetWeatherForCityOutput
{
    /// <summary>
    /// Gets or sets current weather.
    /// </summary>
    [JsonPropertyName("current")]
    public CurrentWeatherModel Current { get; set; }

    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    [JsonPropertyName("forecast")]
    public ForecastWeatherModel Forecast { get; set; }
}