namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

using System.Text.Json.Serialization;

public class ForecastDayModel
{
    /// <summary>
    /// Gets or sets Temperature Celcius.
    /// </summary>
    [JsonPropertyName("maxtemp_c")]
    public double MaxTemperatureCelcius { get; set; }

    /// <summary>
    /// Gets or sets Temperature Farenheit.
    /// </summary>
    [JsonPropertyName("maxtemp_f")]
    public double MaxTemperatureFarenheit  { get; set; }

    /// <summary>
    /// Gets or sets Temperature Celcius.
    /// </summary>
    [JsonPropertyName("mintemp_c")]
    public double MinTemperatureCelcius { get; set; }

    /// <summary>
    /// Gets or sets Temperature Farenheit.
    /// </summary>
    [JsonPropertyName("mintemp_f")]
    public double MinTemperatureFarenheit  { get; set; }

    /// <summary>
    /// Gets or sets Temperature Celcius.
    /// </summary>
    [JsonPropertyName("avgtemp_c")]
    public double AverageTemperatureCelcius { get; set; }

    /// <summary>
    /// Gets or sets Temperature Farenheit.
    /// </summary>
    [JsonPropertyName("avgtemp_f")]
    public double AverageTemperatureFarenheit { get; set; }

    /// <summary>
    /// Gets or sets condition.
    /// </summary>
    [JsonPropertyName("condition")]
    public ConditionModel Condition { get; set; }
}