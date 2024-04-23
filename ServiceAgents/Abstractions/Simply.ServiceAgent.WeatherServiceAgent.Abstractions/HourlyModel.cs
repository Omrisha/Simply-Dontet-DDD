using System.Text.Json.Serialization;

namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

/// <summary>
/// Hourly model.
/// </summary>
public class HourlyModel
{
    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    [JsonPropertyName("time")]
    public DateTime[] Time { get; set; }

    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    [JsonPropertyName("temperature_2m")]
    public double[] Temperature { get; set; }
    
    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    [JsonPropertyName("relative_humidity_2m")]
    public int[] RelativeHumidity { get; set; }
    
    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    [JsonPropertyName("wind_speed_10m")]
    public double[] WindSpeed { get; set; }
}