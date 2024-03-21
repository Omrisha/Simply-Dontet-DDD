namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

using System.Text.Json.Serialization;

public class ForecastModel
{
    /// <summary>
    /// Gets or sets date.
    /// </summary>
    [JsonPropertyName("date")]
    public string Date { get; set; }

    /// <summary>
    /// Gets or sets day forecast.
    /// </summary>
    [JsonPropertyName("day")]
    public ForecastDayModel Day { get; set; }
}
