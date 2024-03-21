namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

using System.Text.Json.Serialization;

/// <summary>
/// Current weather model.
/// </summary>
public class CurrentWeatherModel
{
    /// <summary>
    /// Gets or sets Temperature Celcius.
    /// </summary>
    [JsonPropertyName("temp_c")]
    public double TemperatureCelcius { get; set; }

    /// <summary>
    /// Gets or sets Temperature Farenheit.
    /// </summary>
    [JsonPropertyName("temp_f")]
    public double TemperatureFarenheit { get; set; }

    /// <summary>
    /// Gets or sets condition.
    /// </summary>
    [JsonPropertyName("condition")]
    public ConditionModel Condition { get; set; }
}
