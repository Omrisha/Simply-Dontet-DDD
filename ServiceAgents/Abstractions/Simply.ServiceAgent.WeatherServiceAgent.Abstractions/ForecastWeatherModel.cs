namespace Simply.ServiceAgent.WeatherServiceAgent.Abstractions;

using System.Text.Json.Serialization;

public class ForecastWeatherModel
{
    /// <summary>
    /// Gets or sets forecast.
    /// </summary>
    [JsonPropertyName("forecastday")]
    public ForecastModel[] Forecasts { get; set; }
}
