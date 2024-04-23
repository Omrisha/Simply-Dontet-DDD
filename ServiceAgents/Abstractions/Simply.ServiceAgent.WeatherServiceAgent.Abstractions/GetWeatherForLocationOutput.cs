using System.Text.Json.Serialization;

namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

/// <summary>
/// Get weather for city output.
/// </summary>
public class GetWeatherForLocationOutput
{
    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    [JsonPropertyName("hourly")]
    public HourlyModel Hourly { get; set; }
}